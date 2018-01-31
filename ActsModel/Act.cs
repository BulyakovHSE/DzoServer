using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ActsModel
{
    public class Act
    {
        [Key]
        public int Id { get; set; }

        public int ActNumber { get; set; }

        public string TerritorialBodyName { get; set; }
        
        public DateTime? CreationDate { get; set; }

        public DateTime? MakingStartTime { get; set; }

        public DateTime? MakingEndTime { get; set; }

        public TimeSpan? MakingLength { get; set; }

        public string MakingPlace { get; set; }

        public string ReasonRequisites { get; set; }

        public DateTime? ReasonDate { get; set; }

        public string AreaAdress { get; set; }

        public int AreaNumber { get; set; }

        public string CadastrNumber { get; set; }

        public double AreaSquare { get; set; }

        public ContactInfo CheckContactInfo { get; set; }

        public List<ContactInfo> InvolvedContactInfos { get; set; }

        public string MeasurementDeviceParams { get; set; }

        public CheckClass CheckClass { get; set; }

        public CheckType CheckType { get; set; }

        public ActType ActType { get; set; }

        public Region CreatorRegion { get; set; }

        public byte[] DocumentBytes { get; set; }

        public override bool Equals(object obj)
        {
                return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return ActNumber.GetHashCode() + (TerritorialBodyName==null?0:TerritorialBodyName.GetHashCode()) + (CreationDate==null?0:CreationDate.GetHashCode()) +
                   (MakingStartTime==null?0:MakingStartTime.GetHashCode()) +
                   (MakingEndTime==null?0:MakingEndTime.GetHashCode()) + (MakingLength==null?0:MakingLength.GetHashCode()) + (MakingPlace==null?0:MakingPlace.GetHashCode()) +
                   (ReasonRequisites==null?0:ReasonRequisites.GetHashCode()) +
                   (ReasonDate==null?0:ReasonDate.GetHashCode()) + (AreaAdress==null?0:AreaAdress.GetHashCode()) + AreaNumber.GetHashCode() +
                   (CadastrNumber==null?0:CadastrNumber.GetHashCode()) + AreaSquare.GetHashCode() +
                   (CheckContactInfo==null?0:CheckContactInfo.GetHashCode()) + (InvolvedContactInfos==null?0:InvolvedContactInfos.GetHashCode()) +
                   (MeasurementDeviceParams==null?0:MeasurementDeviceParams.GetHashCode()) + (CheckClass.GetHashCode()) + (CheckType.GetHashCode()) +
                   (ActType.GetHashCode()) + (CreatorRegion.GetHashCode());
        }
    }
}