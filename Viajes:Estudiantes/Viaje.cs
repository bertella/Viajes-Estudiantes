using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBotta
{
	class Viaje
	{
		private int numeroViaje;
		private string lugarDestino;
		private double costoUnitario;
		private int tipoTransporte;

		private Estudiante[] viajeros;

		public Viaje( )
		{

			this.numeroViaje = 0;
			this.lugarDestino = "";
			this.costoUnitario = 0;
			this.tipoTransporte = 0;
			this.viajeros = new Estudiante[50];

		}

		public int pNumeroViajes
		{
			get { return numeroViaje; }
			set { numeroViaje = value; }
		}

		public string pLugarDest
		{
			get { return lugarDestino; }
			set { lugarDestino = value; }

		}

		public double pCostoUnitario
		{
			get { return costoUnitario; }
			set { costoUnitario = value; }

		}


		public int  pTipoTransporte
		{
			get { return tipoTransporte; }
			set { tipoTransporte = value; }

		}


		public Estudiante[]pViajeros
		{
			get { return viajeros ; }
			set { viajeros = value; }

		}

		public string MostrarViaje() {
			string aux = "";

			aux+= "| Viaje Nº:" + numeroViaje + "|Destino:" + lugarDestino + "|Costo: $ " + costoUnitario + 
			"|Tipo de Transporte:" + tipoTransporte;
			if (tipoTransporte == 1)
				aux += "|Transporte Aereo";
			{
				aux += "Transporte Terrestre";
			}
			return aux;
		}

			public double CalcularCostoViaje()  // es el mismo for que agregar viaje  hay que ver que estudiante es 
			{
				double costoTotal = 0;

				for (int i = 0; i < viajeros.Length; i++)
				{

					if (viajeros[i] != null)
					{
						if (viajeros[i].pPromedio >= 9)
						  costoTotal += (costoUnitario * 0.90);
						else
								costoTotal += costoUnitario;
						}                                        
					}
					return costoTotal;
				}

       public double CalcularPorcentaje()
        {
			int mujeres = 0;
			int total = 0;
			for (int i = 0; i < viajeros.Length; i++)
			{

				if (viajeros[i] != null)
				{
					total++; 
                    if (!viajeros[i].pSexo)
                    {
						mujeres++;

                    }
				}
				 
			}
			return mujeres / total * 100;
		}

        public bool AgregarViajero(Estudiante oEstudiante)
		{

			bool exito = true; 
			for (int i = 0; i < viajeros.Length; i++)
			{
				if (viajeros[i] == null)
				{
					viajeros[i] = oEstudiante;
					i = viajeros.Length;
				}
				else {exito = false;  }
				 
			}
			return exito; 

		}
		 


	}
}
