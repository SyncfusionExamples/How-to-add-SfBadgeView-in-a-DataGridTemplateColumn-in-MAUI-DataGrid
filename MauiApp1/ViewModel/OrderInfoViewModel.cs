
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.X86;

namespace MauiApp1
{
    public class EmployeeInfoRepository
    {
        private ObservableCollection<EmployeeInfo> orderInfo;
        public ObservableCollection<EmployeeInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public EmployeeInfoRepository()
        {
            orderInfo = new ObservableCollection<EmployeeInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {


            orderInfo.Add(new EmployeeInfo( 1001, "Jack Parker", "Manager", 1, 0,  130000, "Available"));
            orderInfo.Add(new EmployeeInfo(1002, "Maria Anders", "Project Lead", 1, 0, 87000, "Busy"));
            orderInfo.Add(new EmployeeInfo(1003, "Alice Johnson", "Developer", 5, 2, 57000, "Away"));
            orderInfo.Add(new EmployeeInfo(1004, "John Doe", "Systems Analyst", 2, 2, 43000, "Available"));
            orderInfo.Add(new EmployeeInfo(1004, "Emily Davis", "DevOps Engineer", 2, 1, 46000, "Available"));
            orderInfo.Add(new EmployeeInfo(1005, "Linda Brown", "UI/UX Designer", 5, 3, 39000, "Busy"));
            orderInfo.Add(new EmployeeInfo(1006, "Chris Wilson", "Developer", 3, 1, 42500, "Available"));
            orderInfo.Add(new EmployeeInfo(1007, "James Lee", "Designer", 4, 2, 38000, "None"));
            orderInfo.Add(new EmployeeInfo(1008, "Michael Jackson", "Developer", 3, 1, 37000, "Away"));
            orderInfo.Add(new EmployeeInfo(1009, "Emma Lewis", "Tester", 6, 1, 35000, "Away"));
            orderInfo.Add(new EmployeeInfo(1010, "David Brown", "Support Engineer", 3, 1, 37000, "Available"));


        }
    }

}
