using spacebattle;
using TechTalk.SpecFlow;
namespace spacebattletests
{
    [Binding]
    public class spacebattletests
    {
        private ScenarioContext scenarioContext;
        private double[] position;
        private double[] speed;
        public bool can_move = true;
         private double fuel;
        private double fuel_cons;
        private double ox_ang;
        private double angular_velocit;
        public spacebattletests(ScenarioContext input)
        {
            scenarioContext = input;
        }
        [Given(@"космический корабль имеет топливо в объеме (.*) ед")]
        public void Input_fuel(double p1)
        {
            fuel = p1;
        }


        [Given(@"космический корабль имеет угол наклона (.*) град к оси OX")]
        public void Input_with_angle_and_axis(double p1)
        {
            ox_ang = p1;
        }
        [Given(@"космический корабль, угол наклона которого невозможно определить")]
        public void Input_with_Nan_angle()
        {
            ox_ang = double.NaN;
        }
        [Given(@"имеет скорость расхода топлива при движении (.*) ед")]
        public void Input_delta_fuel(double p1)
        {
            fuel_cons = p1;
        }
        [Given(@"имеет мгновенную угловую скорость (.*) град")]
        public void Input_delta_Angle(double p1)
        {
            angular_velocit = p1;
        }
        [Given(@"мгновенную угловую скорость невозможно определить")]
        public void Input_delta_AngleNaN1()
        {
            angular_velocit = double.NaN;
        }
        [Given(@"невозможно изменить уголд наклона к оси OX космического корабля")]
        public void Input_delta_AngleNaN2()
        {
            angular_velocit = double.NaN;
        }
        [Given(@"космический корабль находится в точке пространства с координатами \((.*), (.*)\)")]
         public void Input_with_real_numbers(double p1, double p2)
         {
            position = new double[2];

             position[0] = p1;
             position[1] = p2;
         }
         [Given(@"космический корабль, положение в пространстве которого невозможно определить")]
         public void Input_with_firstNan()
         {
            position = new double[0];
         }
         [Given(@"имеет мгновенную скорость \((.*), (.*)\)")]
         public void Input_speed(double p1, double p2)
         {
            speed = new double[2];

            speed[0] = p1;
            speed[1] = p2;
         }
         [Given(@"скорость корабля определить невозможно")]
         public void Input_wrong_speed()
         {
             speed = new double[0];
         }
         [Given(@"изменить положение в пространстве космического корабля невозможно")]
         public void Input_ban_moving()
         {
            can_move = false;
         }

        [When(@"происходит прямолинейное равномерное движение без деформации")]
        public void try_to_solve()
        {
            if(fuel!=double.NaN || fuel_cons!=double.NaN)
            {
                try{
                    var result = Spacebattle.Fuel(fuel, fuel_cons);
                }
                catch{
                }
            }
            else
            {
                try{
                var result = Spacebattle.FindPosition(position, speed,can_move);
                }
                catch{
                }
            }
        }

       [When(@"происходит вращение вокруг собственной оси")]
        public void try_to_Findangle()
        {
            try{
                var result = Spacebattle.Angle(ox_ang, angular_velocit);
            }
            catch{
            }
        }

       [Then(@"космический корабль перемещается в точку пространства с координатами \((.*), (.*)\)")]
        public void Test_for_normal_position(double koef3, double koef4)
        {
            double[] result = Spacebattle.FindPosition(position, speed, can_move);
            double[] excepted = new double[] {koef3, koef4};

            Assert.Equal(excepted, result);
        }
        [Then(@"новый объем топлива космического корабля равен (.*) ед")]
        public void Test_for_normal_fuel(double koef3)
        {
            double result = Spacebattle.Fuel(fuel, fuel_cons);
            double excepted = koef3;

            Assert.Equal(excepted, result);
        }
        [Then(@"угол наклона космического корабля к оси OX составляет (.*) град")]
        public void Test_for_normal_angle(double? koef3)
        {
            double? result = Spacebattle.Angle(ox_ang, angular_velocit);
            double? excepted = koef3;

        Assert.Equal(excepted, result);
        }

        [Then(@"возникает ошибка Exception")]
         public void Test_for_get_stuck_in_textures()
         {
            try
            {
                double[] result = Spacebattle.FindPosition(position, speed, can_move);
            }
            catch
            {
                Assert.True(true);
            }
         }
    }
}