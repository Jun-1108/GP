# GP(객체지향 프로그래밍)
## 원본 소스
![원본 form](https://github.com/Jun-1108/GP/assets/48702150/6a072916-810a-445c-a75c-da843ec7cd12)
예약 프로그램을 검색 해 보았지만, 찾을 수가 없어서 예약 프로그램과 최대한 비슷한 프로그램을 찾았습니다.
## 원본 design, cs
![원본 design](https://github.com/Jun-1108/GP/assets/48702150/81a57f55-f6f3-438e-8f8f-efc03ad569b8)
![원본cs](https://github.com/Jun-1108/GP/assets/48702150/88644c71-99c0-4c5e-b5bc-e2a5023166a8)
<br>
## 수정 후
![개선 1](https://github.com/Jun-1108/GP/assets/48702150/a763050f-1f68-4c9f-96cb-6c43f1c24291)
예약을 하기 위해서는 예약하는 사람의 정보가 필요하기 때문에 로그인이 필수라고 생각해서 로그인 창을 만들었습니다.

![개선 2](https://github.com/Jun-1108/GP/assets/48702150/aaabb509-bdbe-4dda-884b-b7363a70e62b)
로그인을 한 후 소비자들이 예약을 하고자하는 점포을 보여주는 창을 만들었습니다.

![개선 3](https://github.com/Jun-1108/GP/assets/48702150/90df0fdf-ee02-4d90-abcb-81e7f8ab5240)
점포에 맞는 주차 자리를 소비자들에게 보여주고 빈자리를 보여주는 프로그램을 만들었습니.
자리 예약이기때문에 시간 또한 중요하다고 판단하였기에 프로그램을 실행 한 시간을 보여주는
현재 시각 창을 만들었습니다.

![개선 3-1](https://github.com/Jun-1108/GP/assets/48702150/5cd0911d-4c9f-42af-a04c-8d881446ebcb)
자신이 원하는 자리에 체크박스를 체크하고 예약하기 버튼을 누르면 '?번 자리를 예약하시겠습니까?' 라는 문구까지 보여주도록 만들었습니다.


![변화 1](https://github.com/Jun-1108/GP/assets/48702150/409f71b8-e0da-451e-a2ba-ba4183b43970)
창을 넘어가기 위해 showDialog를 사용하였습니다. 
![체크박스 ](https://github.com/Jun-1108/GP/assets/48702150/ffe78e56-4365-4648-b863-136845b39abb)
체크 박스마다 예약하는 자리가 다르기때문에 예약버튼을 눌렀을 때 ?번을 바꾸기 위해 if문을 사용했습니다. 
Dispose를 사용하여 창을 끄는 기능도 사용하였습니다.



