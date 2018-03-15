using System.Runtime.Serialization;

namespace ActsModel.Model
{
    [KnownType(typeof(AgreementStatement))]
    [KnownType(typeof(CheckingJournal))]
    [KnownType(typeof(CitizensCheckPlan))]
    [KnownType(typeof(OrderInspectionUlIp))]
    [KnownType(typeof(Protocol))]
    [KnownType(typeof(Regulation))]
    [DataContract]
    public class ActIndividual : ActBase
    {
        
    }
}