using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SessionManager
{
    public sealed class Sesion
    {
        private static Sesion instance = null;
        private static readonly object padlock = new object();

        public static Sesion Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (padlock)
                    {
                        if(instance == null)
                        {
                            instance = new Sesion();
                        }
                    }
                }

                return instance;
            }
        }

        String _IDUsuario;
        String _Usuario;
        String _IDRol;
        String _Rol;
        DataTable _Permisos = new DataTable();

        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }

            set
            {
                _IDUsuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string IDRol
        {
            get
            {
                return _IDRol;
            }

            set
            {
                _IDRol = value;
            }
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }

            set
            {
                _Rol = value;
            }
        }

        public DataTable Permisos
        {
            get
            {
                return _Permisos;
            }
        }

        public void ObtenerPermisos()
        {
            try
            {
                _Permisos = DataSource.Consultas.PERMISOS(_IDRol);
            }
            catch
            {

            }
        }

        public Boolean VerificarPermiso(Int32 pID)
        {
            Boolean verificado = false;
            Int32 IDVerificado = 0;
            foreach(DataRow Fila in _Permisos.Rows)
            {
                IDVerificado = Convert.ToInt32(Fila["IDOpcion"].ToString());
                if(IDVerificado == pID)
                {
                    verificado = true;
                    break;
                }
            }

            if (!verificado)
            {
                System.Windows.Forms.MessageBox.Show("Su usuario no cuenta con la autorización para realizar esta tarea", "Permiso "+pID.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }

            return verificado; 
        }

        private Sesion()
        {

        }
    }
}
