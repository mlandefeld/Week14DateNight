using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week14DateNightCle.Models
{
    public class DateNightModel
    {
        private string title;
        private string dateType;
        private string address;
        private string phoneNum;
        private string photo;
        private string website;
        private string price;

        [Key]
        public int RecordNum { get; set; }

        
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        [Display(Name = "Date Category")]
        public string DateType
        {
            get { return this.dateType; }
            set { this.dateType = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        [Display(Name ="Phone Number")]
        public string PhoneNum
        {
            get { return this.phoneNum; }
            set { this.phoneNum = value; }
        }

        public string Photo
        {
            get { return this.photo; }
            set { this.photo = value; }
        }


        public string Website
        {
            get { return this.website; }
            set { this.website = value; }
        }

        public string Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}