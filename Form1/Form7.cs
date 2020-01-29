using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Form1
{
	public partial class MailNote : Form
	{
		public List<object[]> infos = new List<object[]>();
		public List<string> attachments = new List<string>();

		public MailNote()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		/// <summary>
		/// Creates MailMessage instance, add attachements and content and sends it.
		/// </summary>
		/// <param name="htmlString"></param>
		public void Email(string htmlString)
		{
			using (MailMessage message = new MailMessage("noreply@gmail.com", mailSend.Text))
			{
				MainScreen main = new MainScreen();
				message.From = new MailAddress("noreply@mynotebook.com", "My Notebook App.");
				message.Subject = subject.Text;
				string body = htmlString;

				for(int i = 0; i < this.attachments.Count; i++)
				{
					System.Net.Mail.Attachment attachment;
					attachment = new System.Net.Mail.Attachment(this.attachments[i]);
					message.Attachments.Add(attachment);
				}

				message.Body = body;
				message.IsBodyHtml = true;
				SmtpClient smtp = new SmtpClient();
				smtp.Host = "smtp.gmail.com";
				smtp.EnableSsl = true;
				NetworkCredential NetworkCred = new NetworkCredential("yigitarican@gmail.com", "a.bq14f07.9gd");
				smtp.UseDefaultCredentials = true;
				smtp.Credentials = NetworkCred;
				smtp.Port = 587;
				smtp.Send(message);
			}
		}

		/// <summary>
		/// Sends note as email.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
        {
			string htmlString = string.Format(@"<!DOCTYPE html>
<html style='box-sizing: border-box;font-family: sans-serif;line-height: 1.15;-webkit-text-size-adjust: 100%;-webkit-tap-highlight-color: transparent;'>
<head style='box-sizing: border-box;'>
	<title style='box-sizing: border-box;'></title>
	<meta charset='utf-8' style='box-sizing: border-box;'>
	<link href='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh' crossorigin='anonymous' style='box-sizing: border-box;'></head>
<body style='box-sizing: border-box;margin: 0;font-family: -apple-system,BlinkMacSystemFont,&quot;Segoe UI&quot;,Roboto,&quot;Helvetica Neue&quot;,Arial,&quot;Noto Sans&quot;,sans-serif,&quot;Apple Color Emoji&quot;,&quot;Segoe UI Emoji&quot;,&quot;Segoe UI Symbol&quot;,&quot;Noto Color Emoji&quot;;font-size: 1rem;font-weight: 400;line-height: 1.5;color: #212529;text-align: left;background-color: #fff;min-width: 992px!important;'>
	<div class='container' style='background: #F9F4F4;box-sizing: border-box;width: 100%;padding-right: 15px;padding-left: 15px;margin-right: auto;margin-left: auto;min-width: 992px!important;'>
		<h2 style='margin border-bottom: 0px;box-sizing: border-box;margin-top: 0;margin-bottom: .5rem;font-weight: 500;line-height: 1.2;font-size: 2rem;orphans: 3;widows: 3;page-break-after: avoid;'>MyNotebook Uygulamasından Yeni Notunuz Var!<span class='badge badge-pill badge-danger' style='box-sizing: border-box;display: inline-block;padding: .25em .4em;font-size: 75%;font-weight: 700;line-height: 1;text-align: center;white-space: nowrap;vertical-align: baseline;border-radius: 10rem;transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;border: 1px solid #000;padding-right: .6em;padding-left: .6em;color: #fff;background-color: #dc3545;'>Yeni</span></h2>
		<div class='row' style='padding-top: 10px;box-sizing: border-box;display: flex;-ms-flex-wrap: wrap;flex-wrap: wrap;margin-right: -15px;margin-left: -15px;'>	
			<div class='col-sm' style='border: solid;border-width: 0px 6px;border-color: #F9F4F4;padding: 7px;background: white;box-sizing: border-box;position: relative;width: 100%;padding-right: 15px;padding-left: 15px;'>
				<ul class='list-unstyled' style='margin: 0px;box-sizing: border-box;margin-top: 0;margin-bottom: 1rem;padding-left: 0;list-style: none;'>
					<li class='media' style='box-sizing: border-box;display: flex;-ms-flex-align: start;align-items: flex-start;'>
						<img class='mr-3' style='width: 64px;height: 64px;box-sizing: border-box;vertical-align: middle;border-style: none;page-break-inside: avoid;margin-right: 1rem!important;' src='https://cdn1.iconfinder.com/data/icons/business-487/48/8-512.png'>
						<div class='media-body' style='box-sizing: border-box;-ms-flex: 1;flex: 1;'>
							<h5 class='mt-0 mb-1' style='box-sizing: border-box;margin-top: 0!important;margin-bottom: .25rem!important;font-weight: 500;line-height: 1.2;font-size: 1.25rem;'>{0}</h5>
							{1}
						</div>
					</li>
				</ul>
				<nav aria-label='breadcrumb' style='margin-bottom: 0px;margin-top: 10px;box-sizing: border-box;display: block;'>
					<ol class='breadcrumb' style='box-sizing: border-box;margin-top: 0;margin-bottom: 1rem;display: flex;-ms-flex-wrap: wrap;flex-wrap: wrap;padding: .75rem 1rem;list-style: none;background-color: #e9ecef;border-radius: .25rem;'>
						<li class='breadcrumb-item' style='box-sizing: border-box;'><a href='#' style='box-sizing: border-box;color: #007bff;text-decoration: underline;background-color: transparent;'>{2}</a></li>
						<li class='breadcrumb-item active' aria-current='page' style='box-sizing: border-box;padding-left: .5rem;color: #6c757d;'>{3}</li>
					</ol>
				</nav>
			</div>
		</div>
		<h4 style='margin-top: 13px;margin-bottom: 0px;box-sizing: border-box;font-weight: 500;line-height: 1.2;font-size: 1.5rem;'>Not İçeriği:</h4>
		<p style='box-sizing: border-box;margin-top: 0;margin-bottom: 1rem;orphans: 3;widows: 3;'>{4}</p>
		<div class='card mb-3' style='width: %100;box-sizing: border-box;position: relative;display: flex;-ms-flex-direction: column;flex-direction: column;min-width: 0;word-wrap: break-word;background-color: #fff;background-clip: border-box;border: 1px solid rgba(0,0,0,.125);border-radius: .25rem;margin-bottom: 1rem!important;'>
			<div class='row no-gutters' style='padding: 0px;background: white;box-sizing: border-box;display: flex;-ms-flex-wrap: wrap;flex-wrap: wrap;margin-right: 0;margin-left: 0;'>
				<div class='col-md-4' style='box-sizing: border-box;position: relative;width: 100%;padding-right: 15px;padding-left: 15px;-ms-flex: 0 0 33.333333%;flex: 0 0 33.333333%;max-width: 33.333333%;'>
					<img src='https://www.incimages.com/uploaded_files/image/970x450/getty_883231284_200013331818843182490_335833.jpg' style='width: 350px;height: 200px;box-sizing: border-box;vertical-align: middle;border-style: none;page-break-inside: avoid;-ms-flex-negative: 0;flex-shrink: 0;border-top-left-radius: calc(.25rem - 1px);border-top-right-radius: calc(.25rem - 1px);border-bottom-right-radius: calc(.25rem - 1px);border-bottom-left-radius: calc(.25rem - 1px);' class='card-img' alt='...'>
				</div>
				<div class='col-md-8' style='box-sizing: border-box;position: relative;width: 100%;padding-right: 15px;padding-left: 15px;-ms-flex: 0 0 66.666667%;flex: 0 0 66.666667%;max-width: 66.666667%;'>
					<div class='card-body' style='box-sizing: border-box;-ms-flex: 1 1 auto;flex: 1 1 auto;min-height: 1px;padding: 1.25rem;'>
						<h5 class='card-title' style='box-sizing: border-box;margin-top: 0;margin-bottom: .75rem;font-weight: 500;line-height: 1.2;font-size: 1.25rem;'>My Notebook Uygulaması</h5>
						<p class='card-text' style='margin-top: 8px;margin-bottom: 35px;box-sizing: border-box;orphans: 3;widows: 3;'>MyNotebook uygulamasını hemen şimdi indirin ve karışıklığa son verin! Not alın, kaydedin ve daha fazlası...</p>
					</div>
				</div>
			</div>
		</div>
		<footer style='box-sizing: border-box;display: block;'></footer><p style='box-sizing: border-box;margin-top: 0;margin-bottom: 1rem;orphans: 3;widows: 3;'>MyNotebook App&copy; 2020. All rights reserved.</p>
		
	</div>
</body>
</html>", infos[0]);
			Email(htmlString);
			this.Close();
		}
		
	}
	
}



