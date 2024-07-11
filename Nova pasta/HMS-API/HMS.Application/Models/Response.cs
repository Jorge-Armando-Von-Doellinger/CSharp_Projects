using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Models
{
    public sealed class Response<TEntity>
    {
        public bool Success { get; set; } = true;
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public List<TEntity?>? Data { get; set; }
        public TEntity? SingleData { get; set; }
    }
}
