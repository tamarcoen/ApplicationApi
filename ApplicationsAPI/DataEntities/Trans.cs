using System;
using System.Collections.Generic;
using System.Text;

namespace DataEntities
{
    public class Trans
    {
        public int id { get; set; }
        public int transType { get; set; }
        public int amount { get; set; }
        public int cardId { get; set; }
    }
}
