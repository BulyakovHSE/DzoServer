using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    [KnownType(typeof(ActInpectationFl))]
    [KnownType(typeof(ActInspectationUlIp))]
    [KnownType(typeof(ActInspection))]
    [KnownType(typeof(PhotoTable))]
    [KnownType(typeof(AreaMeasurement))]
    [DataContract]
    public class ActCommon : ActBase
    {
        [DataMember]
        public int CommonNum { get; set; }
    }
}