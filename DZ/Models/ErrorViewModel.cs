using System;

namespace DZ.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public int Id { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
