using doLittle.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class AutomaticReplyDefined : IEvent
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public int Type { get; set; }
        public string Language { get; set; }
        public string Message { get; set; }
    }
}
