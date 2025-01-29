using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    [Serializable]
    public class QuizException : Exception
    {
        public QuizException() { }
        public QuizException(string message) : base(message) { }
        public QuizException(string message, Exception inner) : base(message, inner) { }
        protected QuizException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
