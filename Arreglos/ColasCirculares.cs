

namespace Arreglos
{
    internal class ColasCirculares
    {
        private string[] _arreglo;
        private int _inicio;
        private int _regreso;

        public ColasCirculares(int Elementos)
        {
            _arreglo = new string[Elementos];
            _inicio = 0;
            _regreso = 0;
        }

        private bool EstaLleno()
        {
            return _regreso == _arreglo.Length;
        }
        public void Agregar(string dato)
        {
            try
            {

                if (EstaLleno())
                {
                    throw new Exception("No hay espacio");
                }
                _arreglo[_regreso] = dato;
                _regreso++;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool EstaVacio()
        {
            return _inicio == _regreso;
        }
        public void Eliminar(string dato)
        {
            try
            {

                if (EstaVacio())
                {
                    throw new Exception("Esta Vacio");
                }
                _arreglo[_inicio] = string.Empty;
                _inicio ++;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string ObtenerDatos()
        {
            string acumulado = string.Empty;
            for (int i= _inicio; i < _regreso; i++)
            {
                acumulado += _arreglo[i];
            }
            return acumulado;
        }




    }
}