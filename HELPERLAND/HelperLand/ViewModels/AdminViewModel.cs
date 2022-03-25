﻿using System.Collections.Generic;
using HelperLand.Models;

namespace HelperLand.ViewModels
{
    public class AdminViewModel
    {
        public List<ServiceRequest> serviceRequest { get; set; }

        public List<User> userData { get; set; }
        public User AdminData { get; set; }
        public List<UserCity> cityData { get; set; }

        public UserCity city { get; set; }
        public List<Rating> ratingData { get; set; }






        public int totalServiceRequest { get; set; }




        public int IdForNew { get; set; }
        public int IdForCompleted { get; set; }
        public int IdForCanceled { get; set; }
        public int IdForRefunded { get; set; }
        public int IdForCanceledFromHelper { get; set; }
        public int IdForPending { get; set; }
        public int IdForAccepted { get; set; }

        public UserBasicData userBasicData2 { get; set; }
        public List<UserBasicData> userBasicDataAdmin { get; set; }

        public RattingData rattingdata1 { get; set; }
        public List<RattingData> rattingdataList { get; set; }



        public int UserIdForAD { get; set; }
        public int ServiceIdForAction { get; set; }
    }

    public class UserCity
    {
        public int uId { get; set; }

        public string CityName { get; set; }

        public string PostalCode { get; set; }
    }

    public class RattingData
    {
        public int serviceProviderId { get; set; }
        public float totalRatting { get; set; }
    }
   
}
