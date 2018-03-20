using System.Runtime.Serialization;

namespace DlrModel.Model
{
    [KnownType(typeof(ActInpectationFl))]
    [KnownType(typeof(ActInspectationUlIp))]
    [KnownType(typeof(ActInspection))]
    [KnownType(typeof(PhotoTable))]
    [KnownType(typeof(AreaMeasurement))]
    [DataContract]
    public class ActCommon : ActBase
    {
        public ActCommon(ActType actType):base(actType){}
        public ActCommon():base(ActType.Базовый){}

        [DataMember]
        public int CommonNum { get; set; }
    }
}