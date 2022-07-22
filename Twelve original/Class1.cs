using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Twelve_original
{
    [Serializable]
    public class Class1
    {

        #region Propiedades
        public int[,] tablero { get; private set; }
        public int totalfilas { get; private set; }
        public int totalcolumnas { get; private set; }
        public int puntuacion { get;  set; }
        public int Movimientos { get; set; }
        public bool Modo { get; set; }
        #endregion
        public Class1(int totalfilas, int totalcolumnas)
        {
            this.totalfilas = totalfilas;
            this.totalcolumnas = totalcolumnas;
            this.tablero = new int[totalfilas, totalcolumnas];
            //Modo = false;
            if (totalcolumnas <= 6 && totalfilas <= 6)
            {
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
            }
            if ((totalcolumnas >= 7 || totalfilas >= 7) && (totalcolumnas <= 8 || totalfilas <= 8))
            {
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();

            }
            if (totalcolumnas >= 9 && totalfilas >= 9)
            {
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
            }
        }

        #region Mis metodos
        public void Mover(int istart, int iend, int jstart, int jend)
        {

            if (tablero[istart, jstart] == tablero[iend, jend] && tablero[istart, jstart] != 0 && tablero[iend, jend] != 0 && Lee(TableroLee(tablero, totalfilas, totalcolumnas, iend, jend, istart, jstart), istart, jstart, iend, jend)[iend, jend] != 0)
            {
                tablero[iend, jend] += 1;
                tablero[istart, jstart] = 0;
                puntuacion += tablero[iend, jend];
                if (ObservarCasillasVacias())
                 NuevaCasilla();   
                if (Modo)
                    Movimientos++;

            }
            if (tablero[istart, jstart] != 0 && tablero[iend, jend] == 0 && Lee(TableroLee(tablero, totalfilas, totalcolumnas, iend, jend, istart, jstart), istart, jstart, iend, jend)[iend, jend] != 0)
            {
                tablero[iend, jend] = tablero[istart, jstart];
                tablero[istart, jstart] = 0;
                if (ObservarCasillasVacias())
                    NuevaCasilla();
                if (ObservarCasillasVacias())
                    NuevaCasilla();
                if (Modo) Movimientos++;
            }
        }
        public bool PosicionValida(int fila, int columna)
        {
            if (fila >= 0 && fila < totalfilas && columna >= 0 && columna < totalcolumnas)
                return true;
            return false;
        }
        public int[,] Lee(bool[,] tablero, int filainicial, int columnainicial, int filafinal, int columnafinal)
        {

            int totalfilas = tablero.GetLength(0);
            int totalcolumnas = tablero.GetLength(1);
            int[,] distancias = new int[totalfilas, totalcolumnas];
            distancias[filainicial, columnainicial] = 1;
                        //N, S, E, O, 
            int[] df = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, 1, -1 };
            bool hubocambio;
            do
            {
                hubocambio = false;
                for (int f = 0; f < totalfilas; f++)
                {

                    for (int c = 0; c < totalcolumnas; c++)
                    {
                        if (distancias[f, c] == 0) continue;
                        if (!tablero[f, c]) continue;
                        for (int d = 0; d < df.Length; d++)
                        {
                            int vf = f + df[d];
                            int vc = c + dc[d];
                            if (PosicionValida(vf, vc) && distancias[vf, vc] == 0 && tablero[vf, vc])
                            {
                                distancias[vf, vc] = distancias[f, c] + 1;
                                hubocambio = true;
                                break;

                            }
                        }
                    }
                }

            }
            while (hubocambio);
            return distancias;
        }
        public bool[,] TableroLee(int[,] tablero, int totalfilas, int totalcolumnas, int filafinal, int columnafinal, int filainicial, int columnainicial)
        {
            bool[,] tablerolee = new bool[totalfilas, totalcolumnas];

            for (int i = 0; i < totalfilas; i++)
            {
                for (int j = 0; j < totalcolumnas; j++)
                {
                    if (tablero[i, j] != 0)
                    {
                        tablerolee[i, j] = false;

                    }
                    else
                        tablerolee[i, j] = true;

                }
            }
            tablerolee[filainicial, columnainicial] = true;
            tablerolee[filafinal, columnafinal] = true;
            return tablerolee;

        }
        public void NuevaCasilla()
        {
            int a;
            int b;
            Random amanda = new Random();
            while (true)
            {
                a = amanda.Next(0, totalfilas);
                b = amanda.Next(0, totalcolumnas);
                if (tablero[a, b] == 0)
                {
                    tablero[a, b] = amanda.Next(1, 4);
                    break;
                }
            }


        }
        public void Mezclar()
        {
            int m;
            int n;
            Random amy = new Random();

            for (int i = 0; i < totalfilas; i++)
            {
                for (int j = 0; j < totalcolumnas; j++)
                {
                    m = amy.Next(0, totalfilas);
                    n = amy.Next(0, totalcolumnas);
                    if (tablero[m, n] == 0)
                    {
                        if (tablero[i, j] != 0)
                        {
                            tablero[m, n] = tablero[i, j];
                            tablero[i, j] = 0;
                        }

                    }
                    else
                    {
                        for (int h = 0; h < totalfilas; h++)
                        {
                            for (int k = 0; k < totalcolumnas; k++)
                            {
                                if (tablero[h, k] == 0)
                                {
                                    tablero[h, k] = tablero[i, j];
                                    tablero[i, j] = 0;
                                }
                            }
                        }
                    }
                }
            }
        }
        public bool JugadaPerdida()
        {
            int[] df = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, 1, -1 };
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        if (((i + df[y]) < tablero.GetLength(0)) && ((i + df[y]) >= 0))
                        {
                            if (((j + dc[y]) < tablero.GetLength(1)) && ((j + dc[y]) >= 0))
                            {
                                if (tablero[i + df[y], j + dc[y]] == 0 || tablero[i, j] == tablero[i + df[y], j + dc[y]])
                                    return false;
                            }
                        }
                    }
                }

            }
            return true;
        }
        public bool ObservarCasillasVacias()
        {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == 0) return true;
                }
            }
            return false;
        }
        public void InicializarTablero()
        {
            for (int i = 0; i < totalfilas; i++)
            {
                for (int j = 0; j < totalcolumnas; j++)
                {
                    tablero[i, j] = 0;

                }
            }
            if (totalcolumnas <= 6 && totalfilas <= 6)
            {
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
            }
            if ((totalcolumnas >= 7 || totalfilas >= 7) && (totalcolumnas <= 8 || totalfilas <= 8))
            {
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();

            }
            if (totalcolumnas >= 9 && totalfilas >= 9)
            {
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
                NuevaCasilla();
            }
            Movimientos = 0;
        }
        public void Salvar(Class1 miclase)
        {
            IFormatter salva = new BinaryFormatter();
            Stream archivo = new FileStream("Salva.hit", FileMode.Create, FileAccess.Write);
            salva.Serialize(archivo, miclase);
            archivo.Close();

        }
        public Class1 Cargar()
        {
            Class1 board = null;
            IFormatter salva = new BinaryFormatter();
            if (File.Exists("Salva.hit"))
            {
                Stream t = new FileStream("salva.hit", FileMode.Open, FileAccess.Read);
                board = (Class1)salva.Deserialize(t);
                t.Close();
            }
            return board;
        }
        #endregion

    }
}

