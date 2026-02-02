using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception_prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static class NameCheck
        {
            public static Result<string> Check(string name)
            {   
                // 비면x, 2글자미만x, admin포함x
                if (name == "")
                {
                    return Result<string>.Fail("닉네임을 입력해주세요.");
                }
                else if (name.Length < 2)
                {
                    return Result<string>.Fail("닉네임은 2글자 이상이어야 합니다.");
                }
                else if (name.Contains("admin"))
                {
                    return Result<string>.Fail("닉네임에 'admin'은 포함할 수 없습니다.");
                }
                    return Result<string>.Ok($"{name}으로 등록 완료");
            }
        }

        class Result<T>
        {
            public bool Success { get; }
            public T Value { get; }
            public string Message { get; }

            private Result(bool success, T value, string message)
            {
                Success = success;
                Value = value;
                Message = message;
            }

            public static Result<T> Ok(T value)
            {
                return new Result<T>(true, value, "닉네임 등록 완료");
            }

            public static Result<T> Fail(string message)
            {
                return new Result<T>(false, default, message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;

                Result<string> result = NameCheck.Check(name);

                if (result.Success)
                {
                    label1.Text = $"{result.Value}";
                }
                else
                {
                    label1.Text = $"오류: {result.Message}";
                }
            }
            catch (Exception ex)
            {
                label1.Text = $"오류: {ex.Message}";
            }
            finally
            {
                //MessageBox.Show("프로그램을 종료합니다.");
            }
        }
    }
}
