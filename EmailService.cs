using System;
using System.Net;
using System.Net.Mail;

namespace HotelRes1
{
    public class EmailService
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _senderEmail;
        private readonly string _senderPassword;

        public EmailService(string smtpServer, int smtpPort, string senderEmail, string senderPassword)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _senderEmail = senderEmail;
            _senderPassword = senderPassword;
        }

        public bool SendReservationReceived(string recipientEmail, string clientName)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress(_senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Reservation Received";
                    mail.Body = $@"
                <html>
                <body style='font-family: Arial, sans-serif;'>
                    <h2>Reservation Received</h2>
                    <p>Dear {clientName},</p>
                    <p>We have received your reservation request. It is currently under review, and we will confirm the details shortly.</p>
                    <p>Thank you for choosing our hotel. We are looking forward to the opportunity to host you!</p>
                    <p>Best regards,<br>Hotel Management</p>
                </body>
                </html>";
                    mail.IsBodyHtml = true;

                    using (var smtp = new SmtpClient(_smtpServer, _smtpPort))
                    {
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(_senderEmail, _senderPassword);
                        smtp.Send(mail);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending reservation received email: {ex.Message}");
                return false;
            }
        }


        public bool SendReservationConfirmation(string recipientEmail, string clientName,
    string roomType, string roomNo, string dateIn, string dateOut)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress(_senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Hotel Reservation Confirmation";
                    mail.Body = GenerateEmailBody(clientName, roomType, roomNo, dateIn, dateOut);
                    mail.IsBodyHtml = true;

                    using (var smtp = new SmtpClient(_smtpServer, _smtpPort))
                    {
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(_senderEmail, _senderPassword);
                        smtp.Send(mail);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
                return false;
            }
        }

        private string GenerateEmailBody(string clientName, string roomType,
            string roomNo, string dateIn, string dateOut)
        {
            return $@"
        <html>
        <body style='font-family: Arial, sans-serif;'>
            <h2>Hotel Reservation Confirmation</h2>
            <p>Dear {clientName},</p>
            <p>Your reservation has been confirmed with the following details:</p>
            <div style='margin: 20px; padding: 20px; background-color: #f5f5f5;'>
                <p><strong>Room Type:</strong> {roomType}</p>
                <p><strong>Room Number:</strong> {roomNo}</p>
                <p><strong>Check-in Date:</strong> {dateIn}</p>
                <p><strong>Check-out Date:</strong> {dateOut}</p>
            </div>
            <p>Thank you for choosing our hotel. We look forward to your stay!</p>
            <p>Best regards,<br>Hotel Management</p>
        </body>
        </html>";
        }




    }
}