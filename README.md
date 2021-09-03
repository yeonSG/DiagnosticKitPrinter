# DiagnosticKitPrinter
 - 요약 : 대장암진단키트들의 결과를 써멀프린터로 출력하는 프로잭트.

   ## 예상 시나리오
   1. 임베디드컴퓨터 디스플레이에서 Start버튼을 누른다. (트레이 3개가 들어가 있어야 버튼 Enabled됨)
   2. Start명령이 MCU에 전달되고, 기계장치가 돌아가면서 Kit의 바코드값과 결과값 정보를 임베디드컴퓨터로 전송한다.
   3. 전송받은 결과값을 프린터로 출력한다.

# 시스템 구성
 - 써멀프린터 (HMK-054) [제품 링크](http://www.hwasungt.co.kr/?act=shop.goods_view&GS=13&GC=GD01), [메뉴얼 링크](http://www.hwasungt.co.kr/?act=board&bbs_code=sub4_1&bbs_mode=view&bbs_seq=32)
 - 임베디드컴퓨터&디스플래이 (IEC1000Lite-43) [제품 링크](https://www.hnsts.co.kr/Hardware/Iec1000), [메뉴얼 링크](https://www.hnsts.co.kr/UserFiles/attachment/data_down/1-iecseries.pdf)
 - MCU
 - 기계장치(모터 등등..)

# 개발준비
 - [x] 기계 인수
 - [x] 개발환경 구성 - IDE (VS2008, Framework 설치)
 - [x] 개발환경 구성 - H/W (Printer 동작확인, 기계 동작확인)
 - [ ] 임베디드 컴퓨터 -> 프린터 출력테스트 (어떻게 출력하나)
    - 인터패이스는 RS-232, USB 두가지임
    - USB인터페이스의 경우 두가지 문제가 존제함
      1. USB 드라이버 인식문제 (부팅 시 알수없는 USB 장치로 인식함)
      2. 제공되는 .dll 파일의 호환성 (확인결과 일반 windwos에서는 되는데, wince에서는 안되는 것 같음)
    - 즉 RS-232로 해야 할 듯함.
 - [ ] 코드 정리 (기존 프로젝트서 가저오기)
 - [ ] 코드 구성 설계

# 기능개발
 - [ ] GUI 구성
 - [ ] Not defined

# 일정 
 - GUI 예상화면 보내기.
 - 최종 일정.
 