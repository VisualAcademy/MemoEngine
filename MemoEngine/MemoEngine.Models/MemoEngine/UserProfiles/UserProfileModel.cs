/*
    작성자: 박용준 
    타이틀: 메모엔진 - 멤버자격 관리 - UserProfiles 테이블과 일대일인 모델 클래스   
    코멘트: 메모엔진 - 멤버자격 관리 - UserProfiles 테이블과 일대일인 모델 클래스   
    작성일: XXXX-XX-XX
    수정일: XXXX-XX-XX: FirstName과 LastName 속성 등 추가
*/
using System;

namespace MemoEngine.Models
{
    /// <summary>
    /// UserProfileModel 모델 클래스: UserProfiles 테이블과 일대일로 매핑되는 모델 클래스
    /// </summary>
    public class UserProfileModel
    {
        /// <summary>
        /// 일련번호 
        /// </summary>
        public int Id { get; set; }

        #region 공통: Id, UID, TID, ... 
        /// <summary>
        /// Domain.UID: 일련번호(Id), FK
        /// </summary>
        public int UID { get; set; }
        #endregion

        #region 상세 속성들: UserProfiles 테이블과 일대일
        /// <summary>
        /// 암호(패스워드): 클린 텍스트, 양방향, 단방향
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 이메일
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 마지막 로그인 시간
        /// </summary>
        public DateTimeOffset LastLoginDate { get; set; }

        /// <summary>
        /// 마지막 로그인 IP주소
        /// </summary>
        public string LastLoginIp { get; set; }

        /// <summary>
        /// 로그인(방문) 횟수
        /// </summary>
        public int VisitedCount { get; set; }

        /// <summary>
        /// 계정 잠금 여부: 계정 사용 안함 체크박스(계정 사용(0) 또는 잠금(1))
        /// </summary>
        public bool Blocked { get; set; }

        /// <summary>
        /// 전화번호(모바일)
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 전화번호(전화번호): 예비 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 전화번호(휴대전화): 예비
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 주소
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 성별
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 생년월일
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// 국가: KO-KR 형태의 국가 코드 저장 
        /// </summary>
        public string Country { get; set; }
        #endregion

        #region 추가
        /// <summary>
        /// 이름
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 성
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 직책
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 조직
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// 전공
        /// </summary>
        public string Specialty { get; set; }
        #endregion

        /// <summary>
        /// 휴면 사용자 여부
        /// </summary>
        public bool IsSleep { get; set; }

        /// <summary>
        /// 휴면 전환 시점
        /// </summary>
        public DateTimeOffset SleepDate { get; set; }

        /// <summary>
        /// 휴면 알림 메일 전송 여부
        /// </summary>
        public bool IsSendMail { get; set; }

        /// <summary>
        /// 휴면 알림 메일 전송 일시 
        /// </summary>
        public DateTimeOffset SendMailDate { get; set; }
    }
}
