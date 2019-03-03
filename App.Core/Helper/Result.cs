using App.Core.Interfaces.Models;
using System.Collections;
using System.Collections.Generic;

namespace App.Core
{
    public class Result<T>
    {
        private readonly HashSet<Message> _errors;
        private readonly HashSet<Message> _warnings;
        private readonly HashSet<Message> _informations; 
        
        public Result()
        {
            _errors = new HashSet<Message>();
            _warnings = new HashSet<Message>();
            _informations = new HashSet<Message>(); 
        }

        public Result(T data, bool processingStatus, int recordCount = -1)
        {
            _errors = new HashSet<Message>();
            _warnings = new HashSet<Message>();
            _informations = new HashSet<Message>(); 

            this.ProcessingStatus = processingStatus;
            this.Data = data;
            if(recordCount == -1 && this.ProcessingStatus && this.Data.GetType() == typeof(IBaseModel))
                this.RecordCount = 1;
            else if (recordCount == -1 && this.ProcessingStatus && this.Data is ICollection)
                this.RecordCount = ((ICollection)this.Data).Count;
            else
                this.RecordCount = recordCount;
        }

        public int RecordCount { get; set; } = -1;
        public bool ProcessingStatus { get; set; } = false;
        public T Data { get; set; }
        public HashSet<Message> Errors { get; }
        public HashSet<Message> Warnings { get; }
        public HashSet<Message> Informations { get; } 

        public void AddMessage(Message msg)
        {
            if(msg.Type == MessageType.Error)
                if(!this._errors.Contains(msg))
                    this._errors.Add(msg);
            else if (msg.Type == MessageType.Warning)
                if (!this._warnings.Contains(msg))
                    this._warnings.Add(msg);
            else if (msg.Type == MessageType.Information)
                if (!this._informations.Contains(msg))
                    this._informations.Add(msg); 
        }

        public string GetMessages(MessageType msgType, string delimiter = ", ") {
            if (msgType == MessageType.Error)
                return string.Join(delimiter, _errors);
            else if (msgType == MessageType.Warning)
                return string.Join(delimiter, _warnings);
            else if (msgType == MessageType.Information)
                return string.Join(delimiter, _informations); 

            return string.Empty;
        }

        public bool HasMessages(MessageType msgType)
        {
            if (msgType == MessageType.Error && this._errors.Count > 0)
                return true;
            else if (msgType == MessageType.Warning && this._warnings.Count > 0)
                return true;
            else if (msgType == MessageType.Information && this._informations.Count > 0)
                return true; 

            return false;
        }
    }
}
