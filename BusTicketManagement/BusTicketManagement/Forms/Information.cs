using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

using BusTicketManagement.Reports;
using System.IO;

namespace BusTicketManagement.Forms
{

    public partial class Information : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        public Information(DataTable dt)
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus_Ticket_ReservationDataSet4.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.bus_Ticket_ReservationDataSet4.Schedule);
            // TODO: This line of code loads data into the 'bus_Ticket_ReservationDataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bus_Ticket_ReservationDataSet3.Employee);
            // TODO: This line of code loads data into the 'bus_Ticket_ReservationDataSet2.EmpCategory' table. You can move, or remove it, as needed.
            this.empCategoryTableAdapter.Fill(this.bus_Ticket_ReservationDataSet2.EmpCategory);
            // TODO: This line of code loads data into the 'bus_Ticket_ReservationDataSet1.Bus' table. You can move, or remove it, as needed.
            this.busTableAdapter.Fill(this.bus_Ticket_ReservationDataSet1.Bus);
            // TODO: This line of code loads data into the 'bus_Ticket_ReservationDataSet.BusCategory' table. You can move, or remove it, as needed.
            this.busCategoryTableAdapter.Fill(this.bus_Ticket_ReservationDataSet.BusCategory);

        }
        private void btnBusInsert_Click(object sender, EventArgs e)
        {
            int isActice;
            if (chkBxIsActive.Checked) { isActice = 1; } else { isActice = 0; }
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBxBusNumber.Text != "" && txtBxTicketPrice.Text != "")
                {
                    con.Open();
                    string qry = " INSERT INTO king.Bus(BusCatID,BusNumber,NoOfSeats,NoOfActiveSeat,TPrice,IsActive,Remarks) VALUES (@buscatid,@busnumber,@noofseats,@noofactiveseat,@tprice,@isactive,@remarks)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@buscatid", Int32.Parse(cmbxBusCategory.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@busnumber", txtBxBusNumber.Text);
                    cmd.Parameters.AddWithValue("@noofseats", txtBxTotalSeat.Text);
                    cmd.Parameters.AddWithValue("@noofactiveseat", txtBxTotalActiveSeat.Text);
                    cmd.Parameters.AddWithValue("@tprice", txtBxTicketPrice.Text);
                    cmd.Parameters.AddWithValue("@isactive", isActice);
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully!!!");
                    txtBxBusNumber.Text = "";
                    txtBxTotalActiveSeat.Text = "";
                    txtBxTotalSeat.Text = "";
                    txtBxTicketPrice.Text = "";
                    chkBxIsActive.Checked = false;
                    txtRemarks.Text = "";
                    cmbxBusCategory.Text = "--Select--";
                    con.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxBusNumber.Text = "";
            txtBxTotalActiveSeat.Text = "";
            txtBxTotalSeat.Text = "";
            txtBxTicketPrice.Text = "";
            chkBxIsActive.Checked = false;
            txtRemarks.Text = "";
            cmbxBusCategory.Text = "--Select--";
            cmbxBusID.Text = "--Select--";

        }

        private void btnBusUpdate_Click(object sender, EventArgs e)
        {
            int isActice;
            if (chkBxIsActive.Checked) { isActice = 1; } else { isActice = 0; }
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBxBusNumber.Text != "" && txtBxTicketPrice.Text != "")
                {
                    con.Open();
                    string qry = " Update king.Bus set BusCatID=@buscatid,BusNumber=@busnumber,NoOfSeats=@noofseats,NoOfActiveSeat=@noofactiveseat,TPrice=@tprice,IsActive=@isactive,Remarks=@remarks WHERE BusID=@busid";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@buscatid", Int32.Parse(cmbxBusCategory.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@busnumber", txtBxBusNumber.Text);
                    cmd.Parameters.AddWithValue("@noofseats", txtBxTotalSeat.Text);
                    cmd.Parameters.AddWithValue("@noofactiveseat", txtBxTotalActiveSeat.Text);
                    cmd.Parameters.AddWithValue("@tprice", txtBxTicketPrice.Text);
                    cmd.Parameters.AddWithValue("@isactive", isActice);
                    cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text);
                    cmd.Parameters.AddWithValue("@busid", Int32.Parse(cmbxBusCategory.SelectedValue.ToString()));


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully!!!");
                    txtBxBusNumber.Text = "";
                    txtBxTotalActiveSeat.Text = "";
                    txtBxTotalSeat.Text = "";
                    txtBxTicketPrice.Text = "";
                    chkBxIsActive.Checked = false;
                    txtRemarks.Text = "";
                    cmbxBusCategory.Text = "--Select--";
                    cmbxBusID.Text = "--Select--";
                    con.Close();
                }
            }

        }

        private void btnBusDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                con.Open();
                string qry = " DELETE FROM king.Bus WHERE BusID=@busid";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@busid", Int32.Parse(cmbxBusCategory.SelectedValue.ToString()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record delated successfully!!!");
                cmbxBusCategory.Text = "--Select--";
                cmbxBusID.Text = "--Select--";
                con.Close();
            }
        }

        private void btnEmpInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtEmpName.Text != "" && txtCellPhone.Text != "")
                {
                    con.Open();
                    string qry = "INSERT INTO king.Employee (EmployeeName,EmpCatID ,CellPhone,NID,Email) VALUES(@employeename, @empcatid, king.fn_CellNoFormat(@cellphone), @nid, @email)";
                    SqlCommand cmd = new SqlCommand(qry, con);

                    cmd.Parameters.AddWithValue("@employeename", txtEmpName.Text);
                    cmd.Parameters.AddWithValue("@empcatid", Int32.Parse(cmbxEmpCategory.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@cellphone", txtCellPhone.Text);
                    cmd.Parameters.AddWithValue("@nid", txtEmpNID.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmpEmail.Text);



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully!!!");
                    txtEmpName.Text = "";
                    txtCellPhone.Text = "";
                    txtEmpEmail.Text = "";
                    txtEmpNID.Text = "";
                    cmbxEmpCategory.Text = "--Select--";
                    con.Close();
                }
            }
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qry = "Update king.Employee set  EmployeeName=@employeename ,  EmpCatID=@empcatid ,CellPhone=king.fn_CellNoFormat(@cellphone),NID=@nid,Email=@email Where  EmployeeID=@employeeid";
                SqlCommand cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@employeename", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@empcatid", Int32.Parse(cmbxEmpCategory.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@cellphone", txtCellPhone.Text);
                cmd.Parameters.AddWithValue("@nid", txtEmpNID.Text);
                cmd.Parameters.AddWithValue("@email", txtEmpEmail.Text);
                cmd.Parameters.AddWithValue("@employeeid", Int32.Parse(cmbxEmpCategory.SelectedValue.ToString()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated successfully!!!");
                txtEmpName.Text = "";
                txtCellPhone.Text = "";
                txtEmpEmail.Text = "";
                txtEmpNID.Text = "";
                cmbxEmpCategory.Text = "--Select--";
                cmbxEmpID.Text = "--Select--";
                con.Close();

            }
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qry = "DELETE FROM king.Employee WHERE  EmployeeID=@employeeid";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@employeeid", Int32.Parse(cmbxEmpCategory.SelectedValue.ToString()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted successfully!!!");
                txtEmpName.Text = "";
                txtCellPhone.Text = "";
                txtEmpEmail.Text = "";
                txtEmpNID.Text = "";
                cmbxEmpCategory.Text = "--Select--";
                cmbxEmpID.Text = "--Select--";
                con.Close();

            }
        }

        private void btnEmpReset_Click(object sender, EventArgs e)
        {
            txtEmpName.Text = "";
            txtCellPhone.Text = "";
            txtEmpEmail.Text = "";
            txtEmpNID.Text = "";
            cmbxEmpCategory.Text = "--Select--";
            cmbxEmpID.Text = "--Select--";
        }

        private void btnPassInsert_Click(object sender, EventArgs e)
        {
            int isActive;
            if (chkBxPassConfirm.Checked) { isActive = 1; } else { isActive = 0; }
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtPassName.Text != "" && txtPassPhone.Text != "")
                {
                    con.Open();
                    string qry = "INSERT INTO king.TicketPurchase (BusID,ScheduleID,PassengerName,PassengerPhone,Email,NID,JourneyDate,BookedSeatNo,TotalBookedSeat,UnitFare,Vat,ISConfirm)VALUES(@busID,@scheduleID,@passengerName,@passengerPhone,@email,@nID,@journeyDate,@bookedSeatNo,@totalBookedSeat,@unitFare,@vat,@iSConfirm)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@busID", Int32.Parse(cmbxPassBus.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@scheduleID", Int32.Parse(cmbxPassSchedule.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@passengerName", txtPassName.Text);
                    cmd.Parameters.AddWithValue("@passengerPhone", txtPassPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtPassEmail.Text);
                    cmd.Parameters.AddWithValue("@nID", txtPassNID.Text);
                    cmd.Parameters.AddWithValue("@journeyDate", SqlDbType.Date).Value = Convert.ToDateTime(dtpPassJourneyDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@bookedSeatNo", txtPassName.Text);
                    cmd.Parameters.AddWithValue("@totalBookedSeat", txtPassName.Text);
                    cmd.Parameters.AddWithValue("@unitFare", txtPassName.Text);
                    cmd.Parameters.AddWithValue("@vat", txtPassName.Text);
                    cmd.Parameters.AddWithValue("@iSConfirm", isActive);




                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully!!!");
                    txtPassName.Text = "";
                    txtPassPhone.Text = "";
                    txtPassEmail.Text = "";
                    txtPassNID.Text = "";
                    cmbxPassBus.Text = "--Select--";
                    con.Close();
                }
            }
        }

        private void tbPageReport_Click(object sender, EventArgs e)
        {
            //    rptEmloyeeInformaiton rpem = new rptEmloyeeInformaiton();
            //    crystalReportViewerEmp.ReportSource = rpem;
            //}
        }

        private void crystalReportViewerEmp_Load(object sender, EventArgs e)
        {
            rptEmloyeeInformaiton rptEmloyeef = new rptEmloyeeInformaiton();
            crystalReportViewerEmp.ReportSource = rptEmloyeef;
        }
    }
}
