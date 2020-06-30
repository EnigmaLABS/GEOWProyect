using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft;
using Newtonsoft.Json;

namespace GEOWObj
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PointObj
    {
        public enum enumDireccion { Derecha = 1, Izquierda = 2, Arriba = 3, Abajo = 4 }
        public Pen PenObj;

        public int Alto;
        public int Ancho;
        public Color ColorFigura;

        public List<PointObj> Followers;

        //para el modo persecución
        public bool EsLider = false;
        public bool EsPerseguidor = false;

        //dependencias
        private contracts.INeg_BufferPositions _negObj;
        private contracts.INeg_UDPClient _negUDPObj;

        #region privadas - propiedades

        private int _x;
        private int _y;
        private int AnchoLimite;
        private int AltoLimite;
        private enumDireccion _direccion;
        private string guidObject;
        private string nombreobjeto;
        private Int64 _idJourney;

        #endregion

        //comportamiento estandar
        public PointObj(Color PenColor, 
                        int X_Ini, int Y_ini, 
                        int Alto, int Ancho, 
                        enumDireccion DireccionInicial, 
                        int AnchoLienzo, int AltoLienzo, 
                        string Nombre, 
                        contracts.INeg_BufferPositions p_negObj,
                        contracts.INeg_UDPClient p_negUDPObj)
        {
            this.PenObj = new Pen(PenColor);

            _x = X_Ini;
            _y = Y_ini;
            _direccion = DireccionInicial;

            this.Alto = Alto;
            this.Ancho = Ancho;
            this.ColorFigura = PenColor;

            NombreObjeto = Nombre;
            AnchoLimite = AnchoLienzo - Ancho - 5;
            AltoLimite = AltoLienzo - Alto - 55;

            _negObj = p_negObj;
            _negUDPObj = p_negUDPObj;
        }

        //comportamiento Persecucion 
        public PointObj(Color PenColor, 
                        int X_Ini, int Y_ini, 
                        int Alto, int Ancho, 
                        enumDireccion DireccionInicial, 
                        int AnchoLienzo, int AltoLienzo, 
                        string Nombre, 
                        bool esLider, bool esPerseguidor, 
                        contracts.INeg_BufferPositions p_negObj,
                        contracts.INeg_UDPClient p_negUDPObj)
        {
            this.PenObj = new Pen(PenColor);

            _x = X_Ini;
            _y = Y_ini;
            _direccion = DireccionInicial;

            this.Alto = Alto;
            this.Ancho = Ancho;
            this.ColorFigura = PenColor;

            NombreObjeto = Nombre;
            AnchoLimite = AnchoLienzo - Ancho - 5;
            AltoLimite = AltoLienzo - Alto - 55;

            this.EsLider = esLider;
            this.EsPerseguidor = esPerseguidor;

            _negObj = p_negObj;
            _negUDPObj = p_negUDPObj;
        }

        public enumDireccion Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                bool permitido = true;
                switch (value)
                {
                    case enumDireccion.Arriba:

                        permitido = !(_y <= 10);
                        break;

                    case enumDireccion.Abajo:

                        permitido = !(_y >= AltoLimite);
                        break;

                    case enumDireccion.Izquierda:

                        permitido = !(_x <= 10);
                        break;

                    case enumDireccion.Derecha:

                        permitido = !(_x >= AnchoLimite);
                        break;

                }

                if (permitido)
                {
                    _direccion = value;

                    if (this.EsLider)
                    {
                        //informa del cambio de dirección a los perseguidores
                        if (this.Followers != null)
                        {
                            foreach (var follower in this.Followers)
                            {
                                Task resprocess = new Task(() => follower.GetCoordenadasLider(this.X, this.Y));
                                resprocess.Start();
                            }
                        }
                    }
                }
            }
        }

        [JsonProperty]
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value >= AnchoLimite || value < 10)
                {
                    if (this.Y > (AltoLimite / 2))
                    {
                        this.Direccion = enumDireccion.Arriba;
                    }
                    else
                    {
                        this.Direccion = enumDireccion.Abajo;
                    }

                }
                else
                {
                    _x = value;

                    //Graba la posición
                    DTO.InsertPositionDTO _pos = new DTO.InsertPositionDTO()
                    {
                        CreateDate = DateTime.Now,
                        GUIDObject = this.GUIDObject,
                        PointDesc = this.nombreobjeto,
                        X = _x,
                        Y = this.Y,
                        Height = this.Alto,
                        Width = this.Ancho,
                        Color = this.ColorFigura.Name,
                        idJourney = _idJourney
                    };

                    Task _recordposition = new Task(() => _negObj.InsertPosition(_pos));
                    _recordposition.Start();

                    //Serializa y envía objeto vía UDP
                    string str_object = JsonConvert.SerializeObject(_pos);
                    Task _sendposition = new Task(() => _negUDPObj.EnviarMensaje(str_object));
                    _sendposition.Start();
                }
            }
        }

        [JsonProperty]
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value >= AltoLimite || value < 10)
                {
                    if (this.X > AnchoLimite / 2)
                    {
                        this.Direccion = enumDireccion.Izquierda;
                    }
                    else
                    {
                        this.Direccion = enumDireccion.Derecha;
                    }
                }
                else
                {
                    _y = value;

                    //Graba la posición
                    DTO.InsertPositionDTO _pos = new DTO.InsertPositionDTO()
                    {
                        CreateDate = DateTime.Now,
                        GUIDObject = this.GUIDObject,
                        PointDesc = this.nombreobjeto,
                        X = this.X,
                        Y = _y,
                        Height = this.Alto,
                        Width = this.Ancho,
                        Color = this.ColorFigura.Name,
                        idJourney = _idJourney
                    };

                    Task _recordposition = new Task(() => _negObj.InsertPosition(_pos));
                    _recordposition.Start();

                    //Serializa y envía objeto vía UDP
                    string str_object = JsonConvert.SerializeObject(_pos);

                    Task _sendposition = new Task(() => _negUDPObj.EnviarMensaje(str_object));
                    _sendposition.Start();

                }
            }
        }

        [JsonProperty]
        public string GUIDObject
        {
            get
            {
                return getASCIICode(this.NombreObjeto) + this.Alto.ToString() + this.Ancho.ToString() + getASCIICode(this.ColorFigura.Name);
            }
        }

        public string NombreObjeto {

            get { return nombreobjeto; }

            set { nombreobjeto=value.ToLower().Trim(); }
        }

        public void SetIdJourney(Int64 val)
        {
            _idJourney = val;
        }

        //-->>
        #region funciones de movimiento

        public void Muevelo()
        {
            MovimientoEstandar();

            //switch (this.Comportamiento)
            //{
            //    case enumComportamiento.Estandar:

            //        MovimientoEstandar();
            //        break;

            //    case enumComportamiento.Persecucion:

            //        MovimientoEstandar();
            //        break;
            //}
        }

        private void MovimientoEstandar()
        {
            switch (this.Direccion)
            {
                case PointObj.enumDireccion.Derecha:

                    this.X += 10;
                    break;

                case PointObj.enumDireccion.Izquierda:

                    this.X -= 10;
                    break;

                case PointObj.enumDireccion.Arriba:

                    this.Y -= 10;
                    break;

                case PointObj.enumDireccion.Abajo:

                    this.Y += 10;
                    break;
            }
        }

        #endregion


        //-->>
        #region funciones de comunicación

        public void GetCoordenadasLider(int X_Lider, int Y_Lider)
        {
            int distanciaX = X_Lider - this.X;
            int distanciaY = Y_Lider - this.Y;

            int distanciaAbsolutaX = distanciaX < 0 ? distanciaX * -1 : distanciaX;
            int distanciaAbsolutaY = distanciaX < 0 ? distanciaX * -1 : distanciaX;

            if (distanciaAbsolutaX > distanciaAbsolutaY)
            {
                //la prioridad es recortar en el eje X, pero solo se puede hacer si la dirección actual es arriba o abajo
                if (this.Direccion == enumDireccion.Arriba || this.Direccion == enumDireccion.Abajo)
                {
                    //Recortamos en el eje X
                    if (X_Lider < this.X)
                    {
                        this.Direccion = enumDireccion.Izquierda;
                    }
                    else
                    {
                        this.Direccion = enumDireccion.Derecha;
                    }
                }
                else
                {
                    //recortamos en eje Y aunque no sea la prioridad
                    //a menos que la distancia sea "pequeña" en el eje Y en cuyo caso mantenemos la dirección

                    if (distanciaAbsolutaY > 100)
                    {
                        if (Y_Lider < this.Y)
                        {

                            this.Direccion = enumDireccion.Arriba;
                        }
                        else
                        {
                            this.Direccion = enumDireccion.Abajo;
                        }
                    }
                }
            }
            else
            {
                //la prioridad es recortar en el eje Y, pero solo se puede si la dirección actual es izquierda o derecha
                if (this.Direccion == enumDireccion.Izquierda || this.Direccion == enumDireccion.Derecha)
                {
                    //recortamos en eje Y 
                    if (Y_Lider < this.Y)
                    {
                        this.Direccion = enumDireccion.Arriba;
                    }
                    else
                    {
                        this.Direccion = enumDireccion.Abajo;
                    }
                }
                else
                {
                    //recortamos en eje X aunque no sea la prioridad
                    //a menos que la distancia sea "pequeña" en el eje X en cuyo caso mantenemos la dirección
                    if (distanciaAbsolutaX > 100)
                    {
                        {
                            if (X_Lider < this.X)
                            {
                                this.Direccion = enumDireccion.Izquierda;
                            }
                            else
                            {
                                this.Direccion = enumDireccion.Derecha;
                            }
                        }
                    }
                }
            }
        }

        #endregion


        //-->>
        #region Métodos privados

        private string getASCIICode(string texto)
        {
            string res = "";

            for (int cont = 0; cont < texto.Length; cont++)
            {
                res += Encoding.ASCII.GetBytes(texto)[cont].ToString();
            }

            return res;
        }

        #endregion
    }
}