# :1234: 2048

<br />

## :one: 개요

  C#은 마이크로소프트에서 개발한 객체 지향 프로그래밍 언어로 다양한 분야에서 사용되는 언어이다. 수업에서 배운 Window Form을 이용해 만들 수 있는 것을 생각해보다 2048 Game에 대해서 Clone Project를 진행하고자 했다.

![image](https://user-images.githubusercontent.com/33643752/103197873-34e7e980-492a-11eb-9fd7-599d9802c056.png)

  2048은 격자 위에 있는 수많은 타일을 움직여 병합해 2048이라는 숫자의 타일을 만들어 내는 게임이다. 이탈리아의 웹 개발자 가브리엘레 치룰 리가 만든 퍼즐 게임으로 웹, 모바일 앱으로도 나와 있다. 기본 규칙은 2048을 만드는 것이지만  본 게임에서는 2048이 넘어가더라도 게임을 진행할 수 있도록 하였다.

## :two: Docker의 이용

  본 프로젝트에서는 Docker 컨테이너를 이용해 MySQL 8.0.17 버전을 사용해 Scoreboard를 관리한다. 로컬 환경에서 MySQL 서버를 유지하기 위해 13305번 포트에 해당 환경을 설치하게 되었다.  

![image](https://user-images.githubusercontent.com/33643752/103197970-6eb8f000-492a-11eb-8d8b-0ef64d6af774.png)

  C#에서 MySQL을 사용하기 위해 MySQL Data 모듈을 사용해 MySqlConnection 객체를 만들어 현재 Docker 환경에 있는 MySQL과 연동을 진행하였고 직접 Query 문을 작성해 score를 저장하거나 띄워주는 부분의 코드를 작성하였다.

## :three: Visual Basic InputBox

  따로 Form을 생성하지 않고 MessageBox를 통해 사용자 이름의 입력값을 받고 싶었으나 MessageBox에는 해당 속성이 없었다. 따라서 Visual Basic 모듈에 InputBox를 사용하게 되었다.

![image](https://user-images.githubusercontent.com/33643752/103198066-be97b700-492a-11eb-8cc5-6dce2af89b93.png)

## :four: 결론​ 

  프로젝트를 진행하면서 타일을 움직일 때 애니메이션에 고려를 하지 않고 만들게 되었다. 사용자에게 애니메이션을 보여준다면 타일이 움직였고 생겼다는 액션에 대해서 알려줄 수 있을 것 같다. 또한 프로젝트를 진행하면서 방향키에 keydown 이벤트가 먹지 않아 WASD의 움직이는 방식을 바꾸게 되었다. microsoft 사의 dotnet api 문서를 직접 찾아봤을 때 keydown 이벤트에서 방향키를 보안상으로 막아놨다는 글을 보게 되었고 해당 사항을 코드로 풀 수는 있지만 좋지 못하다는 글을 보게 되었다. 이러한 문제점에 대해서 여러 번 해결해나가면서 결국 2048 Game을 만들 수 있게 되었다.

  이번 텀 프로젝트를 진행하면서 C#으로 많은 것을 만들 수 있다는 것을 알 수 있었다. 처음으로 만든 Game이었고 해당 경험은 신기하고 재밌었다. Label을 배열로 관리하는 등 재밌는 코딩 기법에 대해서도 학습을 할 수 있었고 추후 C#에 대해서 어려워하지 않고 많은 것을 만들 수 있을 것 같다는 자신감을 얻게 되었다.



## :five: Stack

- C#
  - Window Form
  - MySQL Data
  - Visual Basic
- Docker
  - MySQL 8.0.17
