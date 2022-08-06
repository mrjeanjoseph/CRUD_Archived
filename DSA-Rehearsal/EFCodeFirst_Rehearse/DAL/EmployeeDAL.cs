using EFCodeFirst_Rehearse.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EFCodeFirst_Rehearse.DAL {
    class EmployeeDAL {
        private string _connStr;

        public EmployeeDAL(IConfiguration iconfig) {
            _connStr = iconfig.GetConnectionString("Default");
            
        }

        public List<Employee> GetEmployeeList() {
            var empList = new List<Employee>();
            try {
                using var conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand("SP_EmployeeLocationDescription", conn) {
                    CommandType = CommandType.StoredProcedure
                };
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    while (reader.Read()) {
                        empList.Add(new Employee {
                            Id = Convert.ToInt32(reader[0]),
                            EmployeeFirstName = Convert.ToString(reader[1])
                        });
                    }
                } else {
                    Console.WriteLine("No data found...,");
                }

                conn.Close();
                reader.Close();
            } catch (Exception ex) {
                throw ex;
            } finally {
                Console.WriteLine("Please any keys to terminate program");
            }
            return empList;
        }
    }
}
