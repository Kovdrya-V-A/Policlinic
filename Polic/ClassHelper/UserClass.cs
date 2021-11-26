using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polic.ClassHelper
{
    class UserClass
    {
        public static EF.Staff person = new EF.Staff();
        public static int staffId;
        public static int doctorActivePatient;
        public static int doctorActiveIdMedCard;
        public static int doctorActiveDisease;

        //public static EF.Patient patient = new EF.Patient();
        //public bool isActiveFrame = false;
    }
}
