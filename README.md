# C-Programming

## 📚 과목 소개 (Course Overview)

| 항목 | 내용 |
|:----:|:-----|
| 🎓 과목명 | C#프로그래밍 |
| 🏫 담당 교수 | 이영교 교수님 |
| 🗓️ 수강 학기 | 2020-2학기 |
| 💡 주요 학습 내용 | C# |
| 🧰 도구 | Visual Studio |
| 🧩 과제 / 프로젝트 | Windows Forms를 이용한 여러 프로그램 |
| 🔗 관련 자료 | [노트 보기](./notes/README.md) / [과제 코드](./assignments/) |

---

## 🗓 주차별 학습 내용 요약

| 주차 | 주요 학습 주제 | 추가된 기능 / 개념 | 예시 코드 및 설명 |
|------|----------------|--------------------|-------------------|
| **1주차** | Windows Forms 기본 구조 이해 | - `Form` 클래스 이해<br>- 버튼 클릭 이벤트(`Button.Click`) 처리<br>- `MessageBox.Show()` 사용 | ```csharp MessageBox.Show("안녕하세용~", "[공지사항]"); ```<br>→ 버튼 클릭 시 팝업창 출력 |
| **2주차** | 입력(TextBox)과 출력(Label/TextBox) 연결 | - `TextBox.Text` 프로퍼티 사용<br>- 이벤트 핸들러 간 데이터 전달<br>- `Dispose()`로 폼 종료 | ```csharp textBox1.Text = "안녕";```<br>→ 버튼 클릭 시 텍스트박스 내용 변경 |
| **3주차** | 사용자 입력 → 출력 변환 | - 입력된 문자열을 가공해서 다른 컨트롤에 출력<br>- 문자열 결합(`+`)과 개행(`\r\n`) 사용 | ```csharp textBox2.Text = textBox1.Text + "님 코로나 19 조심~";``` |
| **4주차** | MessageBox 심화 사용 | - 메시지 박스의 제목/내용 제어<br>- `Convert.ToChar()`로 특수문자 출력 처리 | ```csharp MessageBox.Show(textBox1.Text + "님 오후수업 화이팅", Convert.ToChar(34) + "\"[안내사항]\"" + Convert.ToChar(34)); ``` |
| **5주차** | 복합 데이터 처리 및 문자열 포맷 | - 여러 입력(TextBox1, TextBox2) 결합<br>- 줄바꿈(`\n`, `\r\n`) 활용<br>- 메시지박스와 텍스트박스 동시 출력 | ```csharp textBox3.Text = textBox1.Text + "님~~~!,\r\n당신의 학번은" + textBox2.Text + "\r\n입니다."; ``` |
| **9주차** | 학점 계산 및 조건문 활용 | - 점수 입력 → 학점 계산<br>- `if-else` 및 `switch-case` 활용<br>- 배열과 반복문을 사용한 다수 점수 처리<br>- 별점 평가와 학점별 안내 메시지 구현 | ```csharp if(ijumsu >= 96){ sHakjum = "A+"; } else {...} ```<br>→ 점수에 따라 학점 자동 계산<br>```csharp switch(textBox1.Text){ case "A+": ... } ```<br>→ 학점에 따른 안내 메시지 출력 |
| **11주차** | 신호등 이미지 및 음짤 만들기 | - `Timer`를 이용한 자동 이미지 변경<br>- `PictureBox.Image`로 이미지 표시<br>- 삼중 반복 이미지 출력 (다중 PictureBox) | ```csharp pictureBox1.Image = Image.FromFile("사진경로/1.png");```<br>→ 일정 시간마다 신호등 색 변경<br>```csharp pictureBox2.Image = Image.FromFile("사진경로/2.jpg");```<br>→ 반복적으로 이미지 변경 |
| **12주차** | 마우스로 동작하는 계산기 | - 일반 계산기 / 공학 계산기 모드 전환<br>- 버튼 클릭으로 숫자 및 연산 입력<br>- Clear_Flag, bJjeom_Flag로 상태 관리<br>- 연산자와 특수 연산 처리 (`+`, `-`, `×`, `÷`, `^`, `%`, 팩토리얼, 삼각함수 등)<br>- Form 소유자(`Owner`) 활용 폼 간 데이터 이동 | ```csharp if(Clear_Flag){ textBox1.Text=""; Clear_Flag=false; }```<br>→ 연산 후 숫자 초기화<br>```csharp textBox1.Text = Math.Sin(double.Parse(textBox1.Text)*Math.PI/180).ToString();```<br>→ 삼각함수 계산 |

---

## 🧩 기능 발전 단계별 설명

### 🪜 1단계 — 이벤트 기초
- 버튼 클릭 시 **MessageBox**를 띄우는 단순 이벤트 처리.
- 핵심 개념: `Form`, `Button`, `MessageBox.Show()`  
  ```csharp
  private void button1_Click(object sender, EventArgs e)
  {
      MessageBox.Show("안녕하세용~", "[공지사항]");
  }
  ```
  ---
  ## 🪜 2단계 — 사용자 입력과 컨트롤 다루기
- **목표:** TextBox 내용을 코드로 변경하거나 폼 종료 기능 학습
- **학습 포인트:** 
  - `TextBox.Text` 프로퍼티 사용
  - 이벤트 핸들러를 통한 UI 상호작용
  - `Dispose()`로 폼 종료
- **예시 코드:**
```csharp
private void button1_Click(object sender, EventArgs e)
{
    textBox1.Text = "안녕";
}

private void button2_Click(object sender, EventArgs e)
{
    Dispose(); // 폼 종료
}
```
---
## 🪜 3단계 — 문자열 연산과 출력 다양화

- **목표:** 사용자 입력을 가공하여 다른 컨트롤에 출력
- **학습 포인트:**
  - 입력(TextBox1) → 출력(TextBox2) 구조 이해
  - 문자열 결합(`+`)과 개행(`\r\n`) 사용
- **예시 코드:**
```csharp
private void button1_Click(object sender, EventArgs e)
{
    textBox2.Text = textBox1.Text + "님 코로나 19에 걸리지 않도록 조심하세용~";
}
```
---
## 🪜 4단계 — 문자열 다루기 심화 및 특수문자 처리

**목표:** 메시지 박스에서 특수문자와 제목 출력 제어

**예시 코드:**
```
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show(
        textBox1.Text + "님 오후수업 화이팅",
        Convert.ToChar(34) + "\"[안내사항]\"" + Convert.ToChar(34)
    );
}
```
---
## 🪜 5단계 — 다중 입력과 포맷 제어

**목표:** 여러 입력(TextBox1, TextBox2)을 조합하여 포맷된 문자열 생성

**예시 코드:**
```
private void button1_Click(object sender, EventArgs e)
{
    textBox3.Text = textBox1.Text + "님~~~!,\r\n당신의 학번은" + textBox2.Text + "\r\n입니다.";
    MessageBox.Show(
        textBox1.Text + "님~~~!,\n당신의 학번은" + textBox2.Text + "\n입니다.",
        "\"공지사항\""
    );
}
```
---

## 📘 3주차 — 기타 도구를 이용한 프로그램

### 1. Form1 — 라디오버튼과 체크박스
- **기능:**  
  - 사용자의 연령대 선택(라디오버튼)  
  - 좋아하는 색 선택(체크박스)  
  - 선택한 항목들을 `textBox1`에 출력
- **핵심 학습 포인트:**  
  - `RadioButton.Checked`, `CheckBox.Checked` 사용  
  - 문자열 결합(`+`)과 `Environment.NewLine` 활용
- **예시 코드:**
```csharp
string str = "당신의 연령은 \r\n";
if (radioButton1.Checked) str += radioButton1.Text;
// 체크박스 처리
if(checkBox1.Checked) str += checkBox1.Text + ", ";
textBox1.Text = str + Environment.NewLine + " 입니다.";
```
### 2. Form2 — 콤보박스

- **기능:**
  -이름과 거주지역 선택 후 메시지 박스 출력

- **핵심 학습 포인트:**
  -ComboBox.Items.Add()와 SelectedIndex 사용
  -Form.Load 이벤트에서 초기값 설정

- **예시 코드:**
```
private void Form2_Load(object sender, EventArgs e)
{
    comboBox2.Items.Add("서울특별시");
    comboBox2.Items.Add("인천광역시");
    comboBox2.SelectedIndex = 0;
}
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show(comboBox1.Text + textBox1.Text + "님은 " + comboBox2.Text + "에 거주하십니다.");
}
```
---
### 3. Form3 — 리스트박스

- **기능:**
  - 기본 아이템 추가 및 입력값 추가
  - 선택 항목 다른 리스트박스로 이동/삭제

- **핵심 학습 포인트:**
  - ListBox.Items.Add(), ListBox.Items.Remove() 사용
  - TextBox.Focus()로 입력 포커스 제어

- **예시 코드:**
```
listBox1.Items.Add(textBox1.Text);
textBox1.Text = "";
textBox1.Focus();
listBox2.Items.Add(listBox1.Text);
listBox2.Items.Remove(listBox2.Text);
```
---
### 4. Form4 — 종합 출력

- **기능:**
  - 이름, 성별, 나이, 반려동물 정보 종합 출력

- **핵심 학습 포인트:**
  - 다양한 컨트롤 값 결합
  - 조건문을 이용한 라디오버튼 확인

- **예시 코드:**
```
if(radioButton1.Checked)
{
    textBox2.Text = textBox1.Text + "님은 " + radioButton1.Text + "이고 연령은 " 
                    + comboBox1.Text + "\r\n반려동물은 " + listBox1.Text + " 입니다~";
}
```
---
## 📘 5주차 — 구구단 만들기
### 1. Form1 — 반복문 비교

- **기능:**
  - 1~9단 구구단 출력 (for, while, do-while, while(true) 사용)

- **핵심 학습 포인트:**
  - 반복문 구조 이해
  - 변수 초기화 및 중첩 반복문

  - Environment.NewLine 활용

- **예시 코드 (for 문):**
```
for(int iDan = 1; iDan < 10; iDan++)
{
    for(int num = 1; num < 10; num++)
    {
        textBox1.Text += iDan + "*" + num + "=" + (iDan * num) + "\r\n";
    }
    textBox1.Text += Environment.NewLine;
}
```
---
### 2. Form2 — 3단씩 묶어서 출력

- **기능:**
  - 1~9단을 3단씩 묶어서 출력

- **예시 코드:**
```
for(int iDan = 1; iDan < 10; iDan += 3)
{
    for(int num = 1; num < 10; num++)
    {
        for(int next = 0; next < 3; next++)
        {
            textBox1.Text += (iDan + next) + "*" + num + "=" + ((iDan + next) * num) + "\t\n";
        }
        textBox1.Text += Environment.NewLine;
    }
    textBox1.Text += Environment.NewLine;
}
```
---
### 3. Form3 — while + 중첩 while

- **기능:**
  - while 문으로 3단씩 묶어 출력

- **예시 코드:**
```
uint uDan = 1, uDuisutja = 1, i = 0;
while(uDan < 10)
{
    while(uDuisutja < 10)
    {
        while(i < 3)
        {
            textBox1.Text += (uDan + i) + "X" + uDuisutja + "=" + ((uDan+i)*uDuisutja) + "\t\n";
            i++;
        }
        uDuisutja++;
        textBox1.Text += Environment.NewLine;
        i = 0;
    }
    uDan += 3;
    textBox1.Text += Environment.NewLine;
    uDuisutja = 1;
}
```
---
### 4. Form4 — do-while 반복문

- **기능:**
  - do-while 문으로 3단씩 묶어 출력

- **예시 코드:**
```
uint uDan = 1, uDuisutja = 1, i = 0;
do
{
    do
    {
        do
        {
            textBox1.Text += (uDan + i) + "*" + uDuisutja + "=" + ((uDan+i)*uDuisutja) + "\t\n";
            i++;
        } while(i < 3);
        uDuisutja++;
        textBox1.Text += Environment.NewLine;
        i = 0;
    } while(uDuisutja < 10);
    uDan += 3;
    textBox1.Text += Environment.NewLine;
    uDuisutja = 1;
} while(uDan < 10);
```
---
### 5. Form5 — while(true) 무한 루프

- **기능:**
  - while(true) + break로 3단씩 묶어 출력

- **예시 코드:**
```
uint uDan = 1, uDuisutja = 1, i = 0;
while(true)
{
    while(true)
    {
        while(true)
        {
            textBox1.Text += (uDan + i) + "X" + uDuisutja + "=" + ((uDan+i)*uDuisutja) + "\t\n";
            i++;
            if(i == 3) break;
        }
        i = 0;
        uDuisutja++;
        textBox1.Text += Environment.NewLine;
        if(uDuisutja == 10) break;
    }
    uDan += 3;
    textBox1.Text += Environment.NewLine;
    uDuisutja = 1;
    if(uDan == 10) break;
}
```
---
# 📝 9주차 — 학점 계산과 판단문

---

## 1. Form1 — if~else if 학점 계산
- **기능:**  
  - 점수를 입력받아 학점 계산
  - 100점 만점 기준으로 A+ ~ F까지 분류
- **핵심 학습 포인트:**  
  - `if ~ else if` 문으로 조건 분기
  - `goto`를 사용한 예외 처리 후 포커스 이동
  - `TextBox.SelectionStart`, `SelectionLength`를 활용한 텍스트 선택
- **예시 코드:**
```csharp
if(ijumsu >= 96) sHakjum = "A+";
else if(ijumsu >= 91) sHakjum = "A0";
...
else sHakjum = "F";
textBox2.Text = sHakjum;
```
---
## 2. Form2 — switch 문을 활용한 학점 계산
- **기능:**
  - 점수를 입력받아 5점 단위로 나눈 후 학점 계산
- **핵심 학습 포인트:**
  - switch 문 활용
  - 동일한 case를 여러 조건에 적용 가능

- **예시 코드:**
```
csharp
switch(ijumsu / 5)
{
    case 20:
    case 19: sHakjum = "A+"; break;
    case 18: sHakjum = "A0"; break;
    ...
    default: sHakjum = "F"; break;
}
textBox2.Text = sHakjum;
```
---
## 3. Form3 — 여러 과목 점수 입력 후 학점 계산
- **기능:**
  - 9과목 점수를 입력받아 각각 학점 계산

- **핵심 학습 포인트:**
  - 배열(int[], string[]) 활용
  - 반복문(for)으로 학점 계산 및 출력

- **예시 코드:**
```
csharp
int[] ijumsu = new int[9];
string[] sHakjum = new string[9];

for(int i=0; i<9; i++)
{
    if(ijumsu[i]>=96) sHakjum[i]="A+";
    else if(ijumsu[i]>=91) sHakjum[i]="A0";
    ...
    else sHakjum[i]="F";
}
```
---
## 4. Form4 — 배열 + TextBox 컨트롤 묶음 활용
- **기능:**
  - Form3와 동일하지만 TextBox[] 배열로 입력/출력 통합
- **핵심 학습 포인트:**
  - 반복문으로 여러 TextBox 처리
  - TextBox.Focus()와 텍스트 선택 기능

- **예시 코드:**
```
csharp
txtInput = new TextBox[] { textBox1, ..., textBox9 };
txtOutput = new TextBox[] { textBox10, ..., textBox18 };

for(int i=0; i<9; i++)
{
    ijumsu[i] = int.Parse(txtInput[i].Text);
    ...
    txtOutput[i].Text = sHakjum[i];
}
```
---
## 5. Form5 — 별점에 따른 만족도 출력 (if~else)
- **기능:**
  - 별점 1~5개를 입력받아 만족도 출력
- **핵심 학습 포인트:**
  - 문자열 비교 조건문(if ~ else if) 사용

- **예시 코드:**
```
csharp
if(textBox1.Text == "★") textBox2.Text = "매우 불만족입니다!";
else if(textBox1.Text == "★★") textBox2.Text = "불만족입니다!";
...
```
---
## 6. Form6 — 별점에 따른 만족도 출력 (switch)
- **기능:**
  - Form5와 동일 기능, switch 활용
- **핵심 학습 포인트:**
  - switch 문으로 조건 분기

- **예시 코드:**
```
csharp
switch(textBox1.Text)
{
    case "★": textBox2.Text = "매우 불만족입니다!"; break;
    case "★★": textBox2.Text = "불만족입니다!"; break;
    ...
}
```
---
## 7. Form7 — 학점에 따른 상세 평가 출력
- **기능:**
  - 학점(A+, A0 ~ F)을 입력받아 점수 범위와 평가 메시지 출력

- **핵심 학습 포인트:**
  - switch 문 활용
  - 사용자 입력 검증

- **예시 코드:**
```
csharp
코드 복사
switch(textBox1.Text)
{
    case "A+": textBox2.Text = "96~100점 사이군요. 공부를 정말 열심히 하셨네요!!"; break;
    case "B0": textBox2.Text = "81~85점 사이군요! 나쁘지 않아요!"; break;
    ...
    default: MessageBox.Show("A+, A0 ~F중 입력하세요!", "[경고2]"); break;
}
```
---
# 11주차: 신호등과 애니메이션 프로그램

## 1. 학습 목표
- Windows Forms에서 Timer를 이용한 주기적 이벤트 처리
- PictureBox를 활용한 이미지 변경
- 사용자 정의 함수(프로시저)를 통한 코드 재사용
- 조건문과 삼항연산자를 활용한 이미지 선택 로직 구현

---

## 2. Form1: 신호등 구현 (자작 함수 이용)

### 주요 기능
- `ChangeSinhodoong(int Color)` 함수 정의:
  - 신호등의 상태에 따라 PictureBox에 이미지를 표시
  - `Color` 값에 따라 준비, 빨간불, 노란불, 초록불 이미지 표시
  - Timer 컨트롤을 사용해 주기적으로 `ChangeSinhodoong(colors)` 호출
  - `colors` 값은 1~4 사이를 순환
  - Form Load 시 초기 상태 설정

### 코드 포인트
```csharp
public void ChangeSinhodoong(int Color)
{
    switch(Color)
    {
        case 0:
            pictureBox1.Image = Image.FromFile("신호등(준비중).png");
            break;
        case 1:
            pictureBox1.Image = Image.FromFile("신호등(적색).png");
            break;
        case 2:
            pictureBox1.Image = Image.FromFile("신호등(노란색).png");
            break;
        case 3:
            pictureBox1.Image = Image.FromFile("신호등(녹색).png");
            break;
        case 4:
            pictureBox1.Image = Image.FromFile("신호등(노란색).png");
            break;
    }
}
```
---
## 3. Form2: 신호등 구현 (삼항 연산자 이용)
- **주요 기능**
  - Timer Tick 이벤트에서 삼항연산자를 이용해 이미지 순환
  - 기존 Form1의 switch문 대신 간단하게 colors 값을 관리
```
csharp
pictureBox1.Image = Image.FromFile(
    System.Environment.CurrentDirectory + "/사진모음/신호등/" + 
    (colors >= 5 ? colors = 1 : colors++) + ".png"
);
```
---
## 4. Form3: 여러 애니메이션(음짤) 구현
- **주요 기능**
  - 3개의 PictureBox를 동시에 사용하여 이미지 애니메이션 구현
  - 각 PictureBox별로 이미지 개수에 따라 다른 주기로 반복
  - Timer Tick 이벤트에서 삼항 연산자를 활용하여 이미지 순환
```
csharp
pictureBox1.Image = Image.FromFile(
    System.Environment.CurrentDirectory + "/사진모음/엄마에게 다가가는 새끼 코끼리/" + 
    (color_1 >= 5 ? color_1 = 1 : color_1++) + ".jpg"
);

pictureBox2.Image = Image.FromFile(
    System.Environment.CurrentDirectory + "/사진모음/다가오는 코끼리 두마리/" + 
    (color_2 >= 6 ? color_2 = 1 : color_2++) + ".jpg"
);

pictureBox3.Image = Image.FromFile(
    System.Environment.CurrentDirectory + "/사진모음/돌아서는 오버액션토끼/" + 
    (color_3 >= 7 ? color_3 = 1 : color_3++) + ".jpg"
);
```
- **특징**
  - 각 애니메이션마다 이미지 파일 수가 다름
  - 삼항연산자를 활용하여 반복문 없이 이미지 순환 구현
---
# 12주차: 마우스로 동작하는 계산기 만들기

## 1. 프로젝트 개요
- **목표:** 마우스를 이용해 숫자와 연산자를 클릭하여 계산할 수 있는 **일반 계산기** 및 **공학 계산기** 구현
- **주요 기능**
  1. 숫자 버튼 클릭
  2. 연산자 버튼 클릭
  3. 특수 연산 (제곱, 팩토리얼, 삼각함수 등)
  4. 모드 전환 (일반 계산기 / 공학 계산기)
  5. 도움말 / 개발자 소개 기능

---

## 2. 기본 UI 설정 (`Form1_Load`)
- **폼 초기화**
  - 일반 계산기 모드로 시작 (`groupBox2.Hide()`)
  - 폼 너비 설정: 일반 계산기 550, 공학 계산기 800
  - 메뉴 체크 상태: 일반 계산기 체크, 공학 계산기 체크 해제

- **메뉴**
  - 종료
  - 모드 전환: 일반 계산기 / 공학 계산기
  - 도움말: 개발자 소개, 교수님에게 하고픈 말, 계산기 사용법
  - 개발 환경 및 버전 정보 표시

---

## 3. 숫자 및 점(.) 입력
- 숫자 버튼 (`0~9`, `000`) 클릭 시 TextBox에 입력
- 점(`.`) 입력 시 **중복 방지** (`bJjeom_Flag`)
- Clear_Flag:
  - 이전 연산 후 새로운 숫자를 입력할 때 기존 내용 삭제

---

## 4. 연산자 버튼 처리
- `+`, `-`, `×`, `÷`, `^`, `%` 등의 연산자 클릭 시:
  1. 기존 저장 값과 입력 값을 계산 (`geasan()` 함수 사용)
  2. 입력 값을 저장하고, 선택한 연산자 저장
  3. 다음 숫자 입력 시 TextBox 초기화 (Clear_Flag = true)

- `=` 버튼 클릭 시:  
  - 저장된 연산 수행 후 초기화 (`Stored_Sutja`, `Stored_Younsanja`, `bJjeom_Flag`, `Clear_Flag`)

---

## 5. 특수 기능 버튼
| 버튼 | 기능 |
|------|------|
| `1/X` | 입력값의 역수 계산 |
| `X^2` | 제곱 계산 |
| `X^3` | 세제곱 계산 |
| `X^Y` | 사용자 지정 거듭제곱 |
| `±` | 부호 반전 |
| `n!` | 팩토리얼 (재귀함수 사용) |
| `sin` | 사인값 (degree → rad 변환) |
| `cos` | 코사인값 (degree → rad 변환) |
| `tan` | 탄젠트값 (degree → rad 변환) |
| `|X|` | 절댓값 |
| `1/|X|` | 절댓값 역수 |
| `10^X` | 10의 X제곱 |
| `π` | 원주율 삽입 |
| `√X` | 제곱근 |

---

## 6. 계산 수행 함수 (`geasan()`)
- 이미 입력된 **연산자**가 존재하면, 입력값과 저장값을 계산
- 수행 가능한 연산: `+`, `-`, `×`, `÷`, `^`, `%`
- 결과를 TextBox에 표시 후 다음 연산 대기

---

## 7. 팝업 도움말 폼 (`Form2`, `Form3`, `Form4`)
- 각 폼 버튼 클릭 시 메인 폼으로 돌아감
```csharp
this.Owner.Show(); // 메인폼 표시
this.Close();      // 현재 폼 닫기
```
- 폼 간 소유자 설정(Owner)으로 메인폼과 연결
---
## 8. 구현 포인트

- Clear_Flag: 연산 후 새로운 숫자를 입력할 때 기존 내용을 지우기 위한 플래그
- bJjeom_Flag: 소수점 입력 중복 방지
- Stored_Sutja, Stored_Younsanja: 연산 수행을 위한 값과 연산자 저장
- 재귀 함수 활용: 팩토리얼 계산
- Math 클래스 활용: 제곱, 삼각함수, 절댓값, 제곱근 등
