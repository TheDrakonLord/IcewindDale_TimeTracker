using IcewindDale_TimeTracker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcewindDale_TimeTracker
{
    public partial class frmMain : Form
    {
        const int _yearInSeconds = 31449600;
        const int _monthInSeconds = 2592000;
        const int _dayInSeconds = 86400;
        const int _hourInSeconds = 3600;
        const int _minInSeconds = 60;
        readonly int[] _moonLeftHalf = { 7, 38, 68, 99, 129, 160, 190, 220, 251, 281, 312, 341 };
        readonly int[] _moonNewMoon = { 15, 45, 76, 106, 137, 167, 198, 228, 258, 289, 319, 349 };
        readonly int[] _moonRightHalf = { 23, 53, 83, 114, 144, 175, 205, 236, 266, 297, 327, 356 };
        readonly int[] _moonFull = { 30, 61, 91, 122, 152, 182, 213, 243, 274, 304, 335, 364 };
        readonly int[] _monthStarts = { 1, 32, 62, 92, 123, 153, 183, 214, 244, 275, 305, 335 };
        readonly int[] _monthEnds = { 31, 61, 91, 122, 152, 182, 213, 243, 274, 304, 335, 364 };
        readonly string[] _Holidays = { "No Holiday", "Midwinter", "GreenGrass", "Midsummer", "Highharvestide", "Feast of the Moon" };
        readonly string[] _MoonPhase = { "Left Half Moon", "New Moon", "Right Half Moon", "Full Moon" };
        readonly string[] _monthNames = { "Hammer", "Alturiak", "Ches", "Tarsakh", "Mirtul", "Kythorn", "Flamerule", "Eleasis", "Eleint", "Marpenoth", "Uktar", "Nightal" };
        const int _midwinter = 31;
        const int _greengrass = 122;
        const int _midsummer = 213;
        const int _highHarvestide = 274;
        const int _feastOfTheMoon = 335;
        const int _startYear = 1489;
        const int _startMonth = 1;
        const int _startDate = 1;
        const int _startHour = 0;
        const int _startMin = 0;
        const int _startSec = 0;
        const int _maxDate = 364;
        const int _minDate = 1;
        const int _minMonth = 1;
        const int _maxMonth = 12;
        const int _minHour = 0;
        const int _maxHour = 23;
        const int _minMin = 0;
        const int _maxMin = 59;
        const int _minSec = 0;
        const int _maxSec = 59;
        const int _roundsPerSec = 6;

        int _currentDate = _startDate;
        int _currentDayNJ = _startDate;
        int _currentMonth = _startMonth;
        int _currentYear = _startYear;
        int _currentHour = _startHour;
        int _currentMin = _startMin;
        int _currentSec = _startSec;
        int _currentMoonPhase = 3;
        int _currentHoliday = 0;

        int _blizzStartMonth = 13;
        int _blizzStartDay = 0;
        int _blizzStartHour = 0;
        int _blizzStartMin = 0;
        int _blizzEndMonth = 13;
        int _blizzEndDay = 0;
        int _blizzEndHour = 0;
        int _blizzEndMin = 0;

        int _irlHours = 0;
        int _irlMinutes = 0;
        int _irlSeconds = 0;

        int _rounds = 0;

        int _ch4Start = 0;
        int _ch4ShowdownStart = 0;
        int _ch4ShowdownReduction = 0;
        int _ch4Elapsed = 0;
        bool _ch4Active = false;
        bool _ch4ShowdownActive = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            _currentHoliday = checkHoliday(_currentDate);
            _currentMoonPhase = checkMoonPhase(_currentDate, _currentMonth);
            setPhaseIcon(_currentMoonPhase);

            txtCurYear.Text = _currentYear.ToString();
            txtCurMonth.Text = _monthNames[_currentMonth-1] + " (" + _currentMonth.ToString() + ")";
            txtCurDay.Text = _currentDayNJ.ToString();
            txtCurHour.Text = _currentHour.ToString();
            txtCurMinute.Text = _currentMin.ToString();
            txtCurSecond.Text = _currentSec.ToString();

            txtHoliday.Text = _Holidays[_currentHoliday];
            txtMoonPhase.Text = _MoonPhase[_currentMoonPhase];



            if (_currentHour >= 10 && _currentHour < 14)
            {
                txtDark.BackColor = Color.White;
                txtDark.ForeColor = Color.Black;
                txtDim.BackColor = Color.LightBlue;
                txtDim.ForeColor = Color.White;
            }
            else
            {
                txtDark.BackColor = Color.DarkBlue;
                txtDark.ForeColor = Color.White;
                txtDim.BackColor = Color.White;
                txtDim.ForeColor = Color.Black;
            }

            if (_currentHour >= 0 && _currentHour < 1)
            {
                txtAurora.BackColor = Color.LimeGreen;
            }
            else
            {
                txtAurora.BackColor = Color.White;
            }

            if (_currentMonth >= _blizzStartMonth && _currentDayNJ >= _blizzStartDay && _currentHour >= _blizzStartHour && _currentMin >= _blizzStartMin
                && _currentMonth <= _blizzEndMonth && _currentDayNJ <= _blizzEndDay && _currentHour <= _blizzEndHour && _currentMin <= _blizzStartMin)
            {
                txtBlizzard.BackColor = Color.Red;
            }
            else
            {
                txtBlizzard.BackColor = Color.White;
            }

            if (_currentDate == _moonNewMoon[_currentMonth-1])
            {
                txtSacrifices.BackColor = Color.Red;
            }
            else
            {
                txtSacrifices.BackColor = Color.White;
            }


            if (_ch4Active)
            {
                _ch4Elapsed = ((_currentDate * _dayInSeconds) + (_currentHour * _hourInSeconds) + (_currentMin * _minInSeconds) + _currentSec) - _ch4Start;
                if (_ch4ShowdownActive)
                {
                    checkCh4State(_ch4ShowdownStart - _ch4Start);
                }
                else
                {
                    checkCh4State(_ch4Elapsed - _ch4ShowdownReduction);
                }
            }
            else
            {
                setDefaultCh4State();
            }
        }

        private void advanceTime(int seconds)
        {
            _currentSec += seconds;
            while (_currentSec > _maxSec)
            {
                _currentSec -= _maxSec + 1;
                _currentMin += 1;
            }

            while (_currentMin > _maxMin)
            {
                _currentMin -= _maxMin + 1;
                _currentHour += 1;
            }

            while (_currentHour > _maxHour)
            {
                _currentHour -= _maxHour + 1;
                _currentDate += 1;
            }

            while (_currentDate > _maxDate)
            {
                _currentDate -= _maxDate;
                _currentYear += 1;
                _currentMonth = _minMonth;
            }

            while (_currentDate > _monthEnds[_currentMonth-1])
            {
                _currentMonth += 1;
            }

            _currentDayNJ = _currentDate - _monthStarts[_currentMonth - 1];

            refresh();
        }

        private int checkHoliday(int day)
        {
            int output = 0;
            switch (day)
            {
                case _midwinter:
                    output = 1;
                    break;
                case _greengrass:
                    output = 2;
                    break;
                case _midsummer:
                    output = 3;
                    break;
                case _highHarvestide:
                    output = 4;
                    break;
                case _feastOfTheMoon:
                    output = 5;
                    break;
                default:
                    output = 0;
                    break;
            }

            return output;
        }

        private int checkMoonPhase(int day, int month)
        {
            int output = 3;
            if (_moonLeftHalf[_currentMonth-1] <= _currentDate)
            {
                output = 0;
            }

            if (_moonNewMoon[_currentMonth-1] <= _currentDate)
            {
                output = 1;
            }

            if (_moonRightHalf[_currentMonth-1] <= _currentDate)
            {
                output = 2;
            }

            if (_moonFull[_currentMonth-1] <= _currentDate)
            {
                output = 3;
            }

            return output;
        }

        private void setPhaseIcon(int phase)
        {
            switch (phase)
            {
                case 0:
                    pbxMoonPhase.Image = Resources.half_left_moon;
                    break;
                case 1:
                    pbxMoonPhase.Image = Resources.new_moon;
                    break;
                case 2:
                    pbxMoonPhase.Image = Resources.half_right_moon;
                    break;
                case 3:
                    pbxMoonPhase.Image = Resources.full_moon_icon;
                    break;
                default:
                    pbxMoonPhase.Image = Resources.full_moon_icon;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadData();
            tmrIRL.Enabled = false;
            lblTimer.Text = $"{_irlHours} : {_irlMinutes} : {_irlSeconds}";
            setDefaultCh4State();
            btnEndShowdown.Enabled = false;
            refresh();
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            int seconds = 0;
            if (txtAddYear.Text != null && int.TryParse(txtAddYear.Text, out int year))
            {
                seconds += year * _yearInSeconds;
            }

            if (txtAddMonth.Text != null && int.TryParse(txtAddMonth.Text, out int month))
            {
                seconds += month * _monthInSeconds;
            }

            if (txtAddDay.Text != null && int.TryParse(txtAddDay.Text, out int day))
            {
                seconds += day * _dayInSeconds;
            }

            if (txtAddHour.Text != null && int.TryParse(txtAddHour.Text, out int hour))
            {
                seconds += hour * _hourInSeconds;
            }

            if (txtAddMinute.Text != null && int.TryParse(txtAddMinute.Text, out int minute))
            {
                seconds += minute * _minInSeconds;
            }

            if (txtAddSecond.Text != null && int.TryParse(txtAddSecond.Text, out int secs))
            {
                seconds += secs;
            }

            advanceTime(seconds);

            txtAddSecond.Text = null;
            txtAddMinute.Text = null;
            txtAddHour.Text = null;
            txtAddDay.Text = null;
            txtAddMonth.Text = null;
            txtAddYear.Text = null;
        }

        private void btnAddBlizz_Click(object sender, EventArgs e)
        {

            if (txtBlizzMonth.Text != null && int.TryParse(txtBlizzMonth.Text, out _blizzStartMonth))
            {
                if (txtBlizzDay.Text != null && int.TryParse(txtBlizzDay.Text, out _blizzStartDay))
                {
                    if (txtBlizzHour.Text != null && int.TryParse(txtBlizzHour.Text, out _blizzStartHour))
                    {
                        if (txtBlizzDuration.Text != null && int.TryParse(txtBlizzDuration.Text, out int duration))
                        {
                            _blizzEndMonth = _blizzStartMonth;
                            _blizzEndDay = _blizzStartDay;
                            _blizzEndHour = _blizzStartHour + duration;
                            _blizzEndMin = _blizzStartMin;

                            while (_blizzEndHour > _maxHour)
                            {
                                _blizzEndDay += 1;
                                _blizzEndHour -= _maxHour + 1;
                            }

                            while (_blizzEndDay > _monthEnds[_blizzEndMonth - 1])
                            {
                                _blizzEndDay -= _monthEnds[_blizzEndMonth - 1];
                                _blizzEndMonth += 1;
                            }

                            while (_blizzEndMonth > _maxMonth)
                            {
                                _blizzEndMonth -= _maxMonth;
                            }
                        }
                    }
                }
            }

            
            
            

           

            txtBlizzMonth.Text = null;
            txtBlizzDay.Text = null;
            txtBlizzHour.Text = null;
            txtBlizzMin.Text = null;
            txtBlizzDuration.Text = null;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            storeData();
        }

        private void storeData()
        {
            StreamWriter writer = new StreamWriter("data.txt");
            writer.WriteLine(_currentDate);
            writer.WriteLine(_currentDayNJ);
            writer.WriteLine(_currentMonth);
            writer.WriteLine(_currentYear);
            writer.WriteLine(_currentHour);
            writer.WriteLine(_currentMin);
            writer.WriteLine(_currentSec);
            writer.WriteLine(_currentMoonPhase);
            writer.WriteLine(_currentHoliday);

            writer.WriteLine(_blizzStartMonth);
            writer.WriteLine(_blizzStartDay);
            writer.WriteLine(_blizzStartHour);
            writer.WriteLine(_blizzStartMin);
            writer.WriteLine(_blizzEndMonth);
            writer.WriteLine(_blizzEndDay);
            writer.WriteLine(_blizzEndHour);
            writer.WriteLine(_blizzEndMin);

            writer.Close();
        }

        private void loadData()
        {
            try
            {
                StreamReader reader = new StreamReader("data.txt");
                try
                {

                    do
                    {
                        if (int.TryParse(reader.ReadLine(), out _currentDate))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentDayNJ))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentMonth))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentYear))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentHour))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentMin))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentSec))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentMoonPhase))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _currentHoliday))
                        {

                        }


                        if (int.TryParse(reader.ReadLine(), out _blizzStartMonth))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _blizzStartDay))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _blizzStartHour))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _blizzStartMin))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _blizzEndMonth))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _blizzEndDay))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _blizzEndHour))
                        {

                        }

                        if (int.TryParse(reader.ReadLine(), out _blizzEndMin))
                        {

                        }

                    } while (reader.Peek() != -1);
                }
                catch
                {
                    MessageBox.Show("Data File is Empty");
                }
                finally
                {
                    reader.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Data File not found");
            }

        }

        private void tmrIRL_Tick(object sender, EventArgs e)
        {
            _irlSeconds += 1;
            if (_irlSeconds > _maxSec)
            {
                _irlMinutes += 1;
                _irlSeconds = 0;
            }
            if (_irlMinutes > _maxMin)
            {
                _irlHours += 1;
                _irlMinutes = 0;
            }

            lblTimer.Text = $"{_irlHours} : {_irlMinutes} : {_irlSeconds}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrIRL.Enabled = true;
            tmrIRL.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrIRL.Stop();
        }

        private void btnAddIRL_Click(object sender, EventArgs e)
        {
            tmrIRL.Stop();
            tmrIRL.Enabled = false;
            advanceTime(_irlSeconds + (_irlMinutes * _minInSeconds) + (_irlHours * _hourInSeconds));
            _irlHours = 0;
            _irlMinutes = 0;
            _irlSeconds = 0;
            lblTimer.Text = $"{_irlHours} : {_irlMinutes} : {_irlSeconds}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (tmrIRL.Enabled == true)
            {
                tmrIRL.Stop();
                tmrIRL.Enabled = false;
            }
            _irlHours = 0;
            _irlMinutes = 0;
            _irlSeconds = 0;
            lblTimer.Text = $"{_irlHours} : {_irlMinutes} : {_irlSeconds}";
        }

        private void btnAddRounds_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumRounds.Text, out _rounds))
            {
                advanceTime(_rounds * _roundsPerSec);
                _rounds = 0;
            }
            txtNumRounds.Clear();
        }

        private void btnStartCh4_Click(object sender, EventArgs e)
        {
            _ch4Active = true;
            _ch4Start = (_currentDate * _dayInSeconds) + (_currentHour * _hourInSeconds) + (_currentMin * _minInSeconds) + _currentSec;
            btnStartCh4.Enabled = false;
        }

        private void btnStartShowdown_Click(object sender, EventArgs e)
        {
            _ch4ShowdownActive = true;
            _ch4ShowdownStart = (_currentDate * _dayInSeconds) + (_currentHour * _hourInSeconds) + (_currentMin * _minInSeconds) + _currentSec;
            btnStartShowdown.Enabled = false;
            btnStartShowdown.BackColor = Color.Red;
            btnEndShowdown.Enabled = true;
        }

        private void btnEndShowdown_Click(object sender, EventArgs e)
        {
            _ch4ShowdownActive = false;
            _ch4ShowdownReduction += ((_currentDate * _dayInSeconds) + (_currentHour * _hourInSeconds) + (_currentMin * _minInSeconds) + _currentSec) - _ch4ShowdownStart;
            btnStartShowdown.Enabled = true;
            btnStartShowdown.BackColor = Color.White;
            btnEndShowdown.Enabled = false;
        }

        private void btnResetCh4_Click(object sender, EventArgs e)
        {
            _ch4ShowdownReduction = 0;
            _ch4Elapsed = 0;
            _ch4Active = false;
            btnStartCh4.Enabled = true;
            setDefaultCh4State();
        }

        private void checkCh4State(int elapsedSeconds)
        {
            if (elapsedSeconds > 203400)// at sunblight (repairing)
            {
                setDefaultCh4State();
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 190800)// otw to sunblight
            {
                setDefaultCh4State();
                txtToSunblight.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 147600)// at bryn shander
            {
                setDefaultCh4State();
                txtBrynShander.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 145800)// otw to bryn shander
            {
                setDefaultCh4State();
                txtToBrynShander.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 117000)// at targos
            {
                setDefaultCh4State();
                txtTargos.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 115200)// otw to targos
            {
                setDefaultCh4State();
                txtToTargos.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 108000)// at bremen
            {
                setDefaultCh4State();
                txtBremen.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 102600)// otw to bremen
            {
                setDefaultCh4State();
                txtToBremen.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 95400)// at lonelywood
            {
                setDefaultCh4State();
                txtLonelywood.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 93600)// otw to lonelywood
            {
                setDefaultCh4State();
                txtToLonelywood.BackColor = Color.Red;
                txtCh4SpecialWeather.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 72000)// at termalaine
            {
                setDefaultCh4State();
                txtTermalaine.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 64800)// otw to termalaine
            {
                setDefaultCh4State();
                txtToTermalaine.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 59400)// at caer-konig
            {
                setDefaultCh4State();
                txtCaerKonig.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 55800)// otw to caer-konig
            {
                setDefaultCh4State();
                txtToCaerKonig.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 52200)// at caer-dineval
            {
                setDefaultCh4State();
                txtCaerDineval.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 48600)// otw to caer-dineval
            {
                setDefaultCh4State();
                txtToCaerDineval.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 19800)// at easthaven
            {
                setDefaultCh4State();
                txtEasthaven.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 14400)// otw to easthaven
            {
                setDefaultCh4State();
                txtToEasthaven.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 10800)// at good mead
            {
                setDefaultCh4State();
                txtGoodMead.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 9000)// otw to good mead
            {
                setDefaultCh4State();
                txtToGoodMead.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 7200)// at dougan's hole
            {
                setDefaultCh4State();
                txtDougans.BackColor = Color.Red;
            }
            else if (elapsedSeconds > 0)// otw to dougan's hole
            {
                setDefaultCh4State();
                txtToDougans.BackColor = Color.Red;
            }
            else //at sunblight (undeparted)
            {
                setDefaultCh4State();
            }
        }

        private void setDefaultCh4State()
        {
            txtToDougans.BackColor = Color.White;
            txtDougans.BackColor = Color.White;
            txtToGoodMead.BackColor = Color.White;
            txtGoodMead.BackColor = Color.White;
            txtToEasthaven.BackColor = Color.White;
            txtEasthaven.BackColor = Color.White;
            txtToCaerDineval.BackColor = Color.White;
            txtCaerDineval.BackColor = Color.White;
            txtToCaerKonig.BackColor = Color.White;
            txtCaerKonig.BackColor = Color.White;
            txtToTermalaine.BackColor = Color.White;
            txtTermalaine.BackColor = Color.White;
            txtToLonelywood.BackColor = Color.White;
            txtLonelywood.BackColor = Color.White;
            txtToBremen.BackColor = Color.White;
            txtBremen.BackColor = Color.White;
            txtToTargos.BackColor = Color.White;
            txtTargos.BackColor = Color.White;
            txtToBrynShander.BackColor = Color.White;
            txtBrynShander.BackColor = Color.White;
            txtToSunblight.BackColor = Color.White;
            txtCh4SpecialWeather.BackColor = Color.White;
        }
    }
}
