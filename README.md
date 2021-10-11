# DiagnosticKitPrinter
 - 요약 : 대장암진단키트들의 결과를 써멀프린터로 출력하는 프로잭트.

   ## 예상 시나리오
   1. 임베디드컴퓨터 디스플레이에서 Start버튼을 누른다. (트레이 3개가 들어가 있어야 버튼 Enabled됨)
   2. Start명령이 MCU에 전달됨
   3. 기계장치가 돌아가면서 Kit의 위치를 대주면
   4. 바코드 리더가 바코드값을 읽고, 기계장치는 결과값 정보(색상)을 읽어 임베디드컴퓨터로 전송한다.
   5. 전송받은 결과값과 바코드 값을 프린터로 출력한다.

# 시스템 구성
 - 써멀프린터 (HMK-054) [제품 링크](http://www.hwasungt.co.kr/?act=shop.goods_view&GS=13&GC=GD01), [메뉴얼 링크](http://www.hwasungt.co.kr/?act=board&bbs_code=sub4_1&bbs_mode=view&bbs_seq=32)
 - 임베디드컴퓨터&디스플래이 (IEC1000Lite-43) [제품 링크](https://www.hnsts.co.kr/Hardware/Iec1000), [메뉴얼 링크](https://www.hnsts.co.kr/UserFiles/attachment/data_down/1-iecseries.pdf)
 - 바코드 리더(3320G 하니웰(USB)) [퀵 메뉴얼-kr](https://country.honeywellaidc.com/CatalogDocuments/3320-KOKR-QS%20REV%20A.pdf), [메뉴얼-en](https://www.honeywellaidc.com/zh-cn/-/media/en/files-public/technical-publications/barcode-scanners/vuquest-3320g/3320-ug.pdf)
 - MCU
 - 기계장치(모터, 컬러센서, 트레이 센서 등등..)
 - 트레이 센서 
 - 컬러 센서

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
 - [x]] Printer 출력 확인
 - [x] 코드 정리 (기존 프로젝트서 가저오기)
 - [ ] 코드 구성 설계

# 기능개발
 - [ ] GUI 구성
 - [ ] 바코드 입력 처리부분 (키보드 입력에 대한 처리)
 - [x] Printer Comprot 연결
 - [x] Printer 프로토콜 정의
 - [ ] Printer 출력형식 정의
 - [ ] MCU Comport 연결
 - [ ] MCU Comport 프로토콜 정의
 - [x] 설정파일 정리


# 일정 
 - [x] GUI 예상화면 보내기.
 - 최종 일정.
 

# USB 업데이트 방법
  ### 1. 업데이트 준비
    - 16기가 이하 USB 사용
    - 포맷함(exFAT 방식추천)
    - USBDisk의 \\UpdateFiles 폴더에 업데이트 할 파일 넣음 (.exe 파일과 dll 파일들) *이외의 파일들은 없어야 함.

  ### 2. 업데이트 방법과 순서
    - 기기 전원 off
    - usb 꽂고 기기 전원 on
    - 기기가 켜지고, 프로그램이 실행 됨
    - 몇 초 이후 업데이트 화면이 뜨고 기기가 재부팅됨
    - 재부팅과정에서 usb 제거

  ### 3. 주의사항
    - USBDisk:\\UpdateFiles 폴더에 업데이트 할 파일을 넣어야 합니다. (폴더 이름이 다르면 인식 안됨)
    - *.exe 파일 이름 변경 금지. (기기에 들어있는 .exe파일에 덮어씌어저야 하는데 이름이 다를 경우 두개의 .exe파일이 존제하게 되어 업데이트가 안될 수 있음)