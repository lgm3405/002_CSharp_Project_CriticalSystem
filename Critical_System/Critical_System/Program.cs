using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critical_System
{
    public class Program                // 크리티컬 시스템
    {
        static void Main(string[] args)
        {
            int dmgNum = 753;             // 일반 데미지
            float criNum = 1.5f;          // 크리티컬 데미지 배율
            float resultDmg;              // 새로운 계산 int 변수 생성

            Console.WriteLine("일반 데미지는 {0} 입니다.", dmgNum);     // 일반 데미지 출력

            resultDmg = dmgNum * criNum;        // 일반 데미지에 크리티컬 데미지를 곱한다.

            Console.WriteLine("크리티컬 데미지는 {0} 입니다.", (int)resultDmg);    // 크리티컬 데미지 출력
        }
    }
}
