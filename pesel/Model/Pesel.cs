using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel.Model
{
    class Pesel
    {
        private string numerPesel;
        private int liczbaMiesiacInt;
        private string liczbaMiesiacaString;
        private int liczbaDzien;
        private string liczbaDnia;
        private string liczbaRok;
        private string liczbaRoku;
        private string cyfra;


        #region Plec
        public string Plec
        {
            get
            {
                char cyfraPlec = numerPesel[9];
                int liczbaPlec = int.Parse(cyfraPlec.ToString());
                if (liczbaPlec % 2 == 0)

                    return " Kobieta";

                else
                    return " Mężczyzna";

            }
        }

        #endregion

        #region Miesiac
        public string Miesiac
        {
            get
            {
                liczbaMiesiacaString = numerPesel[2].ToString() + numerPesel[3].ToString();

                int miesiac = int.Parse(liczbaMiesiacaString);

              

                if (miesiac % 20 == 1)
                {
                    return "Styczeń";
                }

                if (miesiac % 20 == 2)
                {
                    return "Luty";
                }

                if (miesiac % 20 == 3)
                {
                    return "Marzec";
                }

                if (miesiac % 20 == 4)
                {
                    return "Kwiecień";
                }

                if (miesiac % 20 == 5)
                {
                    return "Maj";
                }

                if (miesiac % 20 == 6)
                {
                    return "Czerwiec";
                }

                if (miesiac % 20 == 7)
                {
                    return "Lipiec";
                }

                if (miesiac % 20 == 8)
                {
                    return "Sierpień";
                }

                if (miesiac % 20 == 9)
                {
                    return "Wrzesień";
                }

                if (miesiac % 20 == 0)
                {
                    return "Październik";
                }

                if (miesiac % 20 == 11)
                {
                    return "Listopad";
                }

                if (miesiac % 20 == 12)
                {
                    return "Grudzień";
                }

                else
                {
                    return "Błąd";
                }

            }


        }
        #endregion

        #region Dzien
        public string Dzien
        {
            get
            {
                liczbaDnia = numerPesel[4].ToString() + numerPesel[5].ToString();

                return liczbaDnia;

            }
        }
        #endregion

        #region Stulecia

        public string Rok
        {
            get
            {
                liczbaRoku = numerPesel[0].ToString() + numerPesel[1].ToString();
                int roku = int.Parse(liczbaRoku);

                int[] stulecia = new int[] { 1800, 1900, 2000, 2100, 2200 };

                roku = stulecia[liczbaMiesiacInt % 20] + roku;
                

                liczbaRok = roku.ToString();

                return liczbaRok;
            }
        }


        #endregion

        #region Cyfra

        public string Cyfra
        {
            get
            {
                cyfra = numerPesel[9].ToString();

                return cyfra;
            }
        }



        #endregion


        public Pesel(string numer)
        {

            numerPesel = numer;
            WalidacjaNumeruPesel();



        }
        //metody
        private void WalidacjaPoprawnosciZnakow()
        {

            for (int i = 0; i < numerPesel.Length; i++)
            {
                if (numerPesel[i] < '0' || numerPesel[i] > '9')
                {

                    throw new Exception("Podano złe znaki");

                }
            }





        }

        private void WalidacjaIloscZnakow()
        {
            if (numerPesel.Length != 11)
            {
                throw new Exception("Zła liczba znaków");
            }
        }

        private void WalidacjaMiesiaca()
        {


            liczbaMiesiacInt = int.Parse(numerPesel[2].ToString() + numerPesel[3].ToString());



            if (!(liczbaMiesiacInt <= 92 && liczbaMiesiacInt >= 81
                || liczbaMiesiacInt <= 12 && liczbaMiesiacInt >= 01
                || liczbaMiesiacInt <= 32 && liczbaMiesiacInt >= 21
                || liczbaMiesiacInt <= 52 && liczbaMiesiacInt >= 41
                || liczbaMiesiacInt <= 72 && liczbaMiesiacInt >= 61))
            {
                throw new Exception("Podano zły miesiąc");
            }


        }

        private void WalidacjaDnia()
        {

            liczbaDzien = int.Parse(numerPesel[4].ToString() + numerPesel[5].ToString());
            liczbaMiesiacInt = int.Parse(numerPesel[2].ToString() + numerPesel[3].ToString());

            liczbaRoku = numerPesel[0].ToString() + numerPesel[1].ToString();
            int roku = int.Parse(liczbaRoku);



            if (liczbaDzien > 31)
            {
                throw new Exception("Podano błędną liczbę dni");

            }

            else if ((liczbaMiesiacInt % 20 == 4) ||
                (liczbaMiesiacInt % 20 == 6) ||
                ((liczbaMiesiacInt % 20 == 9) ||
                (liczbaMiesiacInt % 20 == 11)
                && liczbaDzien > 30))
            {
                throw new Exception("Podano błędną liczbę dni");

            }

            int year = int.Parse(Rok.ToString());

            //luty
            if ((liczbaMiesiacInt % 20 == 2) && liczbaDzien > 29)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 && liczbaDzien > 28)
                {
                    throw new Exception("Podano błędną liczbę dni");
                }

            }
        }

        private void WalidacjaCyfryKontrolnej()
        {


            int cyfraKontrolna = int.Parse(numerPesel[10].ToString());
            int[] pesel = new int[10];
            for (int i = 0; i < 10; i++)
            {
                pesel[i] = int.Parse(numerPesel[i].ToString());
            }

            int[] wagaCyfr = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int wynik;
            int suma = 0;
            string wynikString;
            int ostatniaCyfra;
            string sumaString;
            int s;
            int m;

            for (int j = 0; j < 10; j++)
            {
                wynik = pesel[j] * wagaCyfr[j];
                if (wynik >= 10)
                {
                    wynikString = wynik.ToString();
                    ostatniaCyfra = int.Parse(wynikString[1].ToString());
                    suma = suma + ostatniaCyfra;
                }
                else
                {
                    suma = suma + wynik;
                }
            }
            sumaString = suma.ToString();
            s = int.Parse(sumaString[1].ToString());

            if (s == 0)
            {
                m = 0;
            }
            else
            {
                m = 10 - s;
            }

            if (cyfraKontrolna != m)
            {
                throw new Exception("Błędna Cyfra Kontrolna");
            }








        }

        private void WalidacjaNumeruPesel()
        {
            WalidacjaIloscZnakow();
            WalidacjaPoprawnosciZnakow();
            WalidacjaMiesiaca();
            WalidacjaDnia(); 
            WalidacjaCyfryKontrolnej(); 
           
        }
       
    }
}
