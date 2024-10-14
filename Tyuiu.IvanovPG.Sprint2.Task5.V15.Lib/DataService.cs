using tyuiu.cources.programming.interfaces.Sprint2;


// ЗАДАНИЕ:
// По данному номера дня, определить его название.


namespace Tyuiu.IvanovPG.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            string res;
            switch (k)
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторник";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг";
                    break;
                case 5:
                    res = "Пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7:
                    res = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException($"День должен быть от 1 до 7. Значение {k}");
            }
            return res;
        }
    }
}


//string res;
//switch (value)
//{
//    case 1:
//        res = "Январь";
//        break;
//    case 2:
//        res = "Февраль";
//        break;
//    case 3:
//        res = "Март";
//        break;
//    case 4:
//        res = "Апрель";
//        break;
//    case 5:
//        res = "Май";
//        break;
//    case 6:
//        res = "Июнь";
//        break;
//    case 7:
//        res = "Июль";
//        break;
//    case 8:
//        res = "Август";
//        break;
//    case 9:
//        res = "Сентябрь";
//        break;
//    case 10:
//        res = "Октябрь";
//        break;
//    case 11:
//        res = "Ноябрь";
//        break;
//    case 12:
//        res = "Декабрь";
//        break;
//    default:
//        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");
//}
//return res;