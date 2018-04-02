using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class EDU_actions
    {
        [Key]
        public int Id { get; set; }

        private int _action;
        
        public int action
        {
            get 
            {
                return action;
            }
            set
            {
                action = value;
            }
        }

    }
}
