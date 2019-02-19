namespace Dul {
    // 숫자 관련 유틸리티
    export class NumberUtility {
        // 세자리마다 콤마 추가 
        static NumberWithCommas(x: number): string {
            return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
        }
    }
}
