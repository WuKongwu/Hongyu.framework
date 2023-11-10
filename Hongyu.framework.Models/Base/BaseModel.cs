
namespace Hongyu.framework.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Guid CreateBy { get; set; }
        public Guid UpdateBy { get; set; }
        public Guid DeleteBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
