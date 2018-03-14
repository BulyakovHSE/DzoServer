using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    [DataContract]
    public class ActCommon : ActBase
    {
        public int CommonNum { get; set; }
    }
}