------------------------------------------------------------------------------------------------------
--[!] 테이블(Table) 설계 - 회원 인증 관련

-- 작성자: 박용준
-- 타이틀: 메모엔진 - 멤버 자격 - 회원 상세 정보
-- 코멘트: 메모엔진 - 멤버 자격 - 회원 상세 정보
-- 작성일: 
-- 수정일: FirstName, LastName 필드 추가 
-- 수정일: Title, Organization, Specialty 필드 추가 
-- 수정일: 닷넷 스탠다드 프로젝트로 이동  
------------------------------------------------------------------------------------------------------

--[02_02] UserProfiles 테이블: 회원 상세 정보, 회원(Users) = Domains + UserProfiles
Create Table dbo.UserProfiles
(
    Id	Int Identity(1, 1) Primary Key Not Null,    -- 일련번호
    UID Int Not Null,                               -- Domains 테이블의 UID값(PK)
    Password NVarChar(255) Null,                    -- 암호(패스워드): 클린 텍스트, 양방향, 단방향(현재는 이 방법만 사용)
    Email NVarChar(255) Null,                       -- 이메일
    LastLoginDate DATETIMEOFFSET Null,              -- 마지막 로그인 시간
    LastLoginIP NVarChar(16) Null,                  -- 마지막 로그인 IP주소
    VisitedCount Int Default(0),                    -- 로그인(방문) 횟수
    Blocked Bit Default(0),                         -- 계정 잠금 여부: 계정 사용 안함 체크박스(계정 사용(0) 또는 잠금(1))

    -- 상세 정보 관련
    PhoneNumber NVarChar(30) NULL,                  -- 전화번호(모바일)
    Phone       NVarChar(30) NULL,                  -- 전화번호(전화번호): 예비 
    Mobile      NVarChar(30) NULL,                  -- 전화번호(휴대전화): 예비 
    Address     NVarChar(500) NULL,                 -- 주소
    Gender		NVarChar(10) NULL,                  -- 성별
    BirthDate	NVarChar(20) NULL,                  -- 생년월일
    Country		NVarChar(50) NULL,                  -- 국가: KO-KR 형태의 국가 코드 저장 

	-- 추가 상세 정보: 해외 사용자를 위한 필드 
	FirstName	NVarChar(50) NULL,					-- 이름
	LastName	NVarChar(50) NULL,					-- 성

	-- 추가 상세 정보: 직장 사용자를 위한 필드
	Title			NVarChar(50) NULL,				-- 직책
	Organization	NVarChar(50) NULL,				-- 조직
	Specialty		NVarChar(50) NULL,				-- 전공

    -- 휴면 계정 관련 
    IsSleep	
        Bit 
        Default(0),                                 -- 휴면 사용자 여부
    SleepDate 
        DateTimeOffset(7),							-- 휴면 전환 시점
    IsSendMail	
        Bit 
        Default(0),                                 -- 휴면 알림 메일 전송 여부
    SendMailDate 
        DateTimeOffset(7)							-- 휴면 알림 메일 전송 일시

    -- 기타 필요한 정보가 있으면 사용자가 더 추가	
    -- 추가...
)
Go
