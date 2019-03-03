using System;
using System.Collections.Generic;

namespace App.Core
{
    public class Message
    {
        public string PropertyName { get; set; }
        public MessageType Type { get; set; } = MessageType.None;
        public string Code { get; set; }
        public string Description { get; set; }

        public Message() { }

        public Message(MessageType msgType, string msgCode, string msgDesc = "", string propertyName = "")
        {
            this.PropertyName = propertyName;
            this.Type = msgType;
            this.Code = msgCode;
            if (!msgDesc.Equals(string.Empty)) 
                this.Description = msgDesc;
            else
                GetMessageDescription();
        }

        private void GetMessageDescription()
        {
            try
            {
                if (this.Type == MessageType.Error)
                    this.Description = App.Core.Resources.Error.ResourceManager.GetString(this.Code);
                else
                    this.Description = App.Core.Resources.Message.ResourceManager.GetString(this.Code);
            }
            catch {
                //this.Description = this.Code;
            }            
        }
    }

    public class MessageComparer : IEqualityComparer<Message>
    {
        public bool Equals(Message x, Message y)
        {
            return x.Code == y.Code && x.Description == y.Description;
        }

        public int GetHashCode(Message obj)
        {
            return obj.Code.GetHashCode() ^ obj.Description.GetHashCode();
        }
    }
}
