 public void setUserCNP(string email, Nullable<decimal> CNP)
        {
            dt.ReadUserDetails(email).CNP = CNP;
        }

        public void setUserSex(string email,string sex)
        {
            dt.ReadUserDetails(email).Sex = sex;
        }

        public void setUserAdresa(string email,string adresa)
        {
            dt.ReadUserDetails(email).Adresa = adresa;
        }

        public void setUserOras(string email,string oras)
        {
            dt.ReadUserDetails(email).Oras = oras;
        }

        public void setUserJudet(string email,string judet)
        {
            dt.ReadUserDetails(email).Judet = judet;
        }

        public void setUserNr_telefon(string email,Nullable<decimal> numar)
        {
            dt.ReadUserDetails()
        }
