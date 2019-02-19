var Dul;
(function (Dul) {
    // 숫자 관련 유틸리티
    var NumberUtility = /** @class */ (function () {
        function NumberUtility() {
        }
        // 세자리마다 콤마 추가 
        NumberUtility.NumberWithCommas = function (x) {
            return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
        };
        return NumberUtility;
    }());
    Dul.NumberUtility = NumberUtility;
})(Dul || (Dul = {}));
//# sourceMappingURL=dul.js.map