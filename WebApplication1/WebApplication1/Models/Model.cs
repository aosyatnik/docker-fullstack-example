using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Model
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Some value to return.
        /// </summary>
        public int Value { get; set; }
    }
}
