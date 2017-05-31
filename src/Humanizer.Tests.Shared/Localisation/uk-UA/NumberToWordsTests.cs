﻿using Xunit;

namespace Humanizer.Tests.Localisation.ukUA
{
    [UseCulture("uk-UA")]
    public class NumberToWordsTests 
    {
        [Theory]
        [InlineData(0, "нуль")]
        [InlineData(1, "один")]
        [InlineData(10, "десять")]
        [InlineData(11, "одинадцять")]
        [InlineData(12, "дванадцять")]
        [InlineData(13, "тринадцять")]
        [InlineData(14, "чотирнадцять")]
        [InlineData(15, "п'ятнадцять")]
        [InlineData(16, "шістнадцять")]
        [InlineData(17, "сімнадцять")]
        [InlineData(18, "вісімнадцять")]
        [InlineData(19, "дев'ятнадцять")]
        [InlineData(20, "двадцять")]
        [InlineData(30, "тридцять")]
        [InlineData(40, "сорок")]
        [InlineData(50, "п'ятдесят")]
        [InlineData(60, "шістдесят")]
        [InlineData(70, "сімдесят")]
        [InlineData(80, "вісімдесят")]
        [InlineData(90, "дев'яносто")]
        [InlineData(100, "сто")]
        [InlineData(200, "двісті")]
        [InlineData(300, "триста")]
        [InlineData(400, "чотириста")]
        [InlineData(500, "п'ятсот")]
        [InlineData(600, "шістсот")]
        [InlineData(700, "сімсот")]
        [InlineData(800, "вісімсот")]
        [InlineData(900, "дев'ятсот")]
        [InlineData(1000, "одна тисяча")]
        [InlineData(2000, "дві тисячі")]
        [InlineData(3000, "три тисячі")]
        [InlineData(4000, "чотири тисячі")]
        [InlineData(5000, "п'ять тисяч")]
        [InlineData(10000, "десять тисяч")]
        [InlineData(100000, "сто тисяч")]
        [InlineData(1000000, "один мільйон")]
        [InlineData(2000000, "два мільйона")]
        [InlineData(10000000, "десять мільйонів")]
        [InlineData(100000000, "сто мільйонів")]
        [InlineData(1000000000, "один мільярд")]
        [InlineData(2000000000, "два мільярда")]
        [InlineData(122, "сто двадцять два")]
        [InlineData(3501, "три тисячі п'ятсот один")]
        [InlineData(111, "сто одинадцять")]
        [InlineData(1112, "одна тисяча сто дванадцять")]
        [InlineData(11213, "одинадцять тисяч двісті тринадцять")]
        [InlineData(121314, "сто двадцять одна тисяча триста чотирнадцять")]
        [InlineData(2132415, "два мільйона сто тридцять дві тисячі чотириста п'ятнадцять")]
        [InlineData(12345516, "дванадцять мільйонів триста сорок п'ять тисяч п'ятсот шістнадцять")]
        [InlineData(751633617, "сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцять")]
        [InlineData(1111111118, "один мільярд сто одинадцять мільйонів сто одинадцять тисяч сто вісімнадцять")]
        [InlineData(-751633617, "мінус сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцять")]
        public void ToWords(int number, string expected)
        {
            Assert.Equal(expected, number.ToWords());
        }

        [Theory]
        [InlineData(122, "сто двадцять дві", GrammaticalGender.Feminine)]
        [InlineData(3501, "три тисячі п'ятсот одна", GrammaticalGender.Feminine)]
        [InlineData(3501, "три тисячі п'ятсот одне", GrammaticalGender.Neuter)]
        public void ToWordsWithGender(int number, string expected, GrammaticalGender gender)
        {
            Assert.Equal(expected, number.ToWords(gender));
        }

        [Theory]
        [InlineData(0, "нульовий")]
        [InlineData(1, "перший")]
        [InlineData(2, "другий")]
        [InlineData(3, "третій")]
        [InlineData(4, "четвертий")]
        [InlineData(10, "десятий")]
        [InlineData(11, "одинадцятий")]
        [InlineData(12, "дванадцятий")]
        [InlineData(13, "тринадцятий")]
        [InlineData(14, "чотирнадцятий")]
        [InlineData(15, "п'ятнадцятий")]
        [InlineData(16, "шістнадцятий")]
        [InlineData(17, "сімнадцятий")]
        [InlineData(18, "вісімнадцятий")]
        [InlineData(19, "дев'ятнадцятий")]
        [InlineData(20, "двадцятий")]
        [InlineData(30, "тридцятий")]
        [InlineData(40, "сороковий")]
        [InlineData(50, "п'ятдесятий")]
        [InlineData(60, "шістдесятий")]
        [InlineData(70, "сімдесятий")]
        [InlineData(80, "вісімдесятий")]
        [InlineData(90, "дев'яностий")]
        [InlineData(100, "сотий")]
        [InlineData(101, "сто перший")]
        [InlineData(140, "сто сороковий")]
        [InlineData(200, "двохсотий")]
        [InlineData(300, "трьохсотий")]
        [InlineData(400, "чотирьохсотий")]
        [InlineData(500, "п'ятисотий")]
        [InlineData(600, "шестисотий")]
        [InlineData(700, "семисотий")]
        [InlineData(800, "восьмисотий")]
        [InlineData(900, "дев'ятисотий")]
        [InlineData(1000, "тисячний")]
        [InlineData(1001, "одна тисяча перший")]
        [InlineData(1040, "одна тисяча сороковий")]
        [InlineData(2000, "двохтисячний")]
        [InlineData(3000, "трьохтисячний")]
        [InlineData(4000, "чотирьохтисячний")]
        [InlineData(5000, "п'ятитисячний")]
        [InlineData(10000, "десятитисячний")]
        [InlineData(21000, "двадцятиоднотисячний")]
        [InlineData(100000, "стотисячний")]
        [InlineData(101000, "стооднотисячний")]
        [InlineData(121000, "стодвадцятиоднотисячний")]
        [InlineData(200000, "двохсоттисячний")]
        [InlineData(1000000, "мільйонний")]
        [InlineData(2000000, "двохмільйонний")]
        [InlineData(10000000, "десятимільйонний")]
        [InlineData(21000000, "двадцятиодномільйонний")]
        [InlineData(100000000, "стомільйонний")]
        [InlineData(230000000, "двохсоттридцятимільйонний")]
        [InlineData(1000000000, "мільярдний")]
        [InlineData(2000000000, "двохмільярдний")]
        [InlineData(122, "сто двадцять другий")]
        [InlineData(3501, "три тисячі п'ятсот перший")]
        [InlineData(111, "сто одинадцятий")]
        [InlineData(1112, "одна тисяча сто дванадцятий")]
        [InlineData(11213, "одинадцять тисяч двісті тринадцятий")]
        [InlineData(121314, "сто двадцять одна тисяча триста чотирнадцятий")]
        [InlineData(2132415, "два мільйона сто тридцять дві тисячі чотириста п'ятнадцятий")]
        [InlineData(12345516, "дванадцять мільйонів триста сорок п'ять тисяч п'ятсот шістнадцятий")]
        [InlineData(751633617, "сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцятий")]
        [InlineData(1111111118, "один мільярд сто одинадцять мільйонів сто одинадцять тисяч сто вісімнадцятий")]
        [InlineData(1111111000, "один мільярд сто одинадцять мільйонів стоодинадцятитисячний")]
        [InlineData(1234567000, "один мільярд двісті тридцять чотири мільйона п'ятисотшістдесятисемитисячний")]
        [InlineData(-751633617, "мінус сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцятий")]
        public void ToOrdinalWords(int number, string expected)
        {
            Assert.Equal(expected, number.ToOrdinalWords());
        }

        [Theory]
        [InlineData(0, "нульова")]
        [InlineData(1, "перша")]
        [InlineData(2, "друга")]
        [InlineData(3, "третя")]
        [InlineData(4, "четверта")]
        [InlineData(10, "десята")]
        [InlineData(11, "одинадцята")]
        [InlineData(12, "дванадцята")]
        [InlineData(13, "тринадцята")]
        [InlineData(14, "чотирнадцята")]
        [InlineData(15, "п'ятнадцята")]
        [InlineData(16, "шістнадцята")]
        [InlineData(17, "сімнадцята")]
        [InlineData(18, "вісімнадцята")]
        [InlineData(19, "дев'ятнадцята")]
        [InlineData(20, "двадцята")]
        [InlineData(30, "тридцята")]
        [InlineData(40, "сорокова")]
        [InlineData(50, "п'ятдесята")]
        [InlineData(60, "шістдесята")]
        [InlineData(70, "сімдесята")]
        [InlineData(80, "вісімдесята")]
        [InlineData(90, "дев'яноста")]
        [InlineData(100, "сота")]
        [InlineData(200, "двохсота")]
        [InlineData(300, "трьохсота")]
        [InlineData(400, "чотирьохсота")]
        [InlineData(500, "п'ятисота")]
        [InlineData(600, "шестисота")]
        [InlineData(700, "семисота")]
        [InlineData(800, "восьмисота")]
        [InlineData(900, "дев'ятисота")]
        [InlineData(1000, "тисячна")]
        [InlineData(2000, "двохтисячна")]
        [InlineData(3000, "трьохтисячна")]
        [InlineData(4000, "чотирьохтисячна")]
        [InlineData(5000, "п'ятитисячна")]
        [InlineData(10000, "десятитисячна")]
        [InlineData(90000, "дев'яностотисячна")]
        [InlineData(100000, "стотисячна")]
        [InlineData(990000, "дев'ятисотдев'яностотисячна")]
        [InlineData(990001, "дев'ятсот дев'яносто тисяч перша")]
        [InlineData(1000000, "мільйонна")]
        [InlineData(2000000, "двохмільйонна")]
        [InlineData(10000000, "десятимільйонна")]
        [InlineData(100000000, "стомільйонна")]
        [InlineData(1000000000, "мільярдна")]
        [InlineData(2000000000, "двохмільярдна")]
        [InlineData(122, "сто двадцять друга")]
        [InlineData(3501, "три тисячі п'ятсот перша")]
        [InlineData(111, "сто одинадцята")]
        [InlineData(1112, "одна тисяча сто дванадцята")]
        [InlineData(11000, "одинадцятитисячна")]
        [InlineData(11001, "одинадцять тисяч перша")]
        [InlineData(11213, "одинадцять тисяч двісті тринадцята")]
        [InlineData(15000, "п'ятнадцятитисячна")]
        [InlineData(20000, "двадцятитисячна")]
        [InlineData(121314, "сто двадцять одна тисяча триста чотирнадцята")]
        [InlineData(2132415, "два мільйона сто тридцять дві тисячі чотириста п'ятнадцята")]
        [InlineData(12345516, "дванадцять мільйонів триста сорок п'ять тисяч п'ятсот шістнадцята")]
        [InlineData(751633617, "сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцята")]
        [InlineData(1111111118, "один мільярд сто одинадцять мільйонів сто одинадцять тисяч сто вісімнадцята")]
        [InlineData(-751633617, "мінус сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцята")]
        public void ToOrdinalWordsFeminine(int number, string expected)
        {
            Assert.Equal(expected, number.ToOrdinalWords(GrammaticalGender.Feminine));
        }

        [Theory]
        [InlineData(3, "третє")]
        [InlineData(111, "сто одинадцяте")]
        [InlineData(1112, "одна тисяча сто дванадцяте")]
        [InlineData(11213, "одинадцять тисяч двісті тринадцяте")]
        [InlineData(121314, "сто двадцять одна тисяча триста чотирнадцяте")]
        [InlineData(2132415, "два мільйона сто тридцять дві тисячі чотириста п'ятнадцяте")]
        [InlineData(12345516, "дванадцять мільйонів триста сорок п'ять тисяч п'ятсот шістнадцяте")]
        [InlineData(751633617, "сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцяте")]
        [InlineData(1111111118, "один мільярд сто одинадцять мільйонів сто одинадцять тисяч сто вісімнадцяте")]
        [InlineData(-751633617, "мінус сімсот п'ятдесят один мільйон шістсот тридцять три тисячі шістсот сімнадцяте")]
        public void ToOrdinalWordsNeuter(int number, string expected)
        {
            Assert.Equal(expected, number.ToOrdinalWords(GrammaticalGender.Neuter));
        }
    }
}
