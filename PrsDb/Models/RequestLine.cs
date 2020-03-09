using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrsDb.Data;
using PrsDb.Models;

namespace PrsDb.Models {
    public class RequestLine {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public virtual Request Request { get; set; }
        public virtual Product Product { get; set; }
        RequestLine() { }

    }
}
