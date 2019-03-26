------------------------------------------------------------------------------------------------------
--[!] 테이블(Table) 설계 - 회원 인증 관련

-- 작성자: 박용준
-- 타이틀: 메모엔진 - 멤버 자격
-- 코멘트: 메모엔진 - 멤버 자격
-- 작성일: 
-- 수정일: 
------------------------------------------------------------------------------------------------------

--[02_01] Domains 테이블: 회원/그룹 필수 정보: Windows NT의 SAM 인용 
Create Table dbo.Domains
(
    UID Int Identity(1, 1) Not Null Primary Key,	-- 일련번호(Id)
    DomainID NVarChar(50) NOT Null,					-- 아이디(UserId)/그룹아이디(GroupId, RoleId), Domainname, Username
    Name NVarChar(100) NOT Null,					-- 이름/그룹명/닉네임(한글 7자, 영문 14자로 제한)
    [AccountType] NVarChar(50) Null,			    -- User/Group, 필드명을 Type에서 AccountType으로 변경
    [Description] NVarChar(255) Null,				-- 계정에 대한 설명(소개)
    CreatedDate	DATETIMEOFFSET Default(GetDate())	-- 가입일(계정 등록일)
)
Go

--#################################################################################
-- hkey_local_machine
-- +-hardware
-- |-sam (p1)
-- |  |-sam (c)(p2)
-- |     |-domains (@)(p2)
-- |     |    |-account (f,v)(p2)
-- |     |    |    |-aliases (@)(p2)
-- |     |    |    |    |-members (@)(p2)
-- |     |    |    |    \-names (@)(p2)
-- |     |    |    |-groups (@)(p2)
-- |     |    |    |    |-00000201 (c)(p2)
-- |     |    |    |    |-names (@)(p2)
-- |     |    |    |        |-none (@)(p2)
-- |     |    |    |-users (@)(p2)
-- |     |    |        |-000001f4 (f,v)(p2)
-- |     |    |        |-000001f5 (f,v)(p2)
-- |     |    |        |-names (@)(p2)
-- |     |    |            |-administrator (@)(p2)
-- |     |    |            |-guest (@)(p2)
-- |     |    |-builtin (f,v)(p2)
-- |     |         |-aliases (@)(p2)
-- |     |         |    |-00000220 (c)(p2)
-- |     |         |    |-00000221 (c)(p2)
-- |     |         |    |-00000222 (c)(p2)
-- |     |         |    |-00000223 (c)(p2)
-- |     |         |    |-00000227 (c)(p2)
-- |     |         |    |-00000228 (c)(p2)
-- |     |         |    |-members (@)(p2)
-- |     |         |    |    |-s-1-5 (@)(p2)
-- |     |         |    |    |   |-00000004 (@)(p2)
-- |     |         |    |    |   \-0000000b (@)(p2)
-- |     |         |    |    |-s-1-5-21-329068152-152049171-854245398 (@)(p2)
-- |     |         |    |                         |-000001f4 (@)(p2)
-- |     |         |    |                         |-000001f5 (@)(p2)
-- |     |         |    |-names (@)(p2)
-- |     |         |        |-administrator (@)(p2)
-- |     |         |        |-backup operators (@)(p2)
-- |     |         |        |-guests (@)(p2)
-- |     |         |        |-power users (@)(p2)
-- |     |         |        |-replicator (@)(p2)
-- |     |         |        |-users (@)(p2)
-- |     |         |-groups (@)(p2)
-- |     |         |    \-names (@)(p2)
-- |     |         |-users (@)(p2)
-- |     |             |-names (@)(p2)
-- |     \-rxact (@)(p2)
-- #################################################################################


--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Aliases
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Aliases\000003E9
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Aliases\Members
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Aliases\Members\S-1-5-21-606747145-764733703-839522115
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Aliases\Members\S-1-5-21-606747145-764733703-839522115\000003EA
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Aliases\Names
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Aliases\Names\HelpServicesGroup
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Groups
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Groups\00000201
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Groups\Names
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Groups\Names\None
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\000001F4
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\000001F5
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\000003E8
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\000003EA
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\000003EB
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\Names
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\Names\Administrator
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\Names\Guest
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\Names\HelpAssistant
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\Names\SUPPORT_388945a0
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Account\Users\Names\%UserName%
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\00000220
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\00000221
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\00000222
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\00000223
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\00000227
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\00000228
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\0000022B
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\0000022C
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members\S-1-5
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members\S-1-5\00000004
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members\S-1-5\0000000B
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members\S-1-5-21-606747145-764733703-839522115
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members\S-1-5-21-606747145-764733703-839522115\000001F4
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members\S-1-5-21-606747145-764733703-839522115\000001F5
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Members\S-1-5-21-606747145-764733703-839522115\000003EB
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Administrators
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Backup Operators
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Guests
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Network Configuration Operators
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Power Users
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Remote Desktop Users
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Replicator
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Aliases\Names\Users
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Groups
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Groups\Names
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Users
--##HKEY_LOCAL_MACHINE\SAM\SAM\Domains\Builtin\Users\Names
--##HKEY_LOCAL_MACHINE\SAM\SAM\RXACT
