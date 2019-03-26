/*
    작성자: 박용준 
    타이틀: 메모엔진 - 멤버자격 관리 - Domains 테이블과 일대일인 모델 클래스   
    코멘트: 메모엔진 - 멤버자격 관리 - Domains 테이블과 일대일인 모델 클래스   
    작성일: XXXX-XX-XX
    수정일: XXXX-XX-XX
*/
using System;
using System.ComponentModel.DataAnnotations;

namespace MemoEngine.Models
{
    /// <summary>
    /// DomainModel 모델 클래스: Domains 테이블과 일대일로 매핑되는 모델 클래스
    /// </summary>
    public class DomainModel
    {
        #region 공통: Id, UID, TID, ... 
        /// <summary>
        /// 일련번호(Id)
        /// </summary>
        [Key]
        public int UID { get; set; }
        #endregion

        #region 기본 속성들: Domains 테이블과 일대일
        /// <summary>
        /// 아이디(UserId)/그룹아이디(GroupId, RoleId)
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// 이름/그룹명/닉네임(한글 7자, 영문 14자로 제한)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User/Group, 나중에 Type을 DomainType으로 바꿔도 무관
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// 계정에 대한 설명(소개)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 가입일(계정 등록일)
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }
        #endregion
    }
}
