﻿using System;

namespace API.ViewModel
{
    public class ChangeVM
    {
        public string Email { get; set; }
        public string OTP { get; set; }
        public string NewPass { get; set; }
        public string ConfirmPass   { get; set; }
    }
}
