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

# 🧭 C# Windows Forms 프로그래밍 (1~5주차 요약)

## 📘 전체 개요
1주차부터 5주차까지의 코드는 C# **Windows Forms**의 기초를 학습하면서  
점진적으로 기능을 확장하는 구조로 되어 있습니다.  
- 핵심 주제: **이벤트 처리, 사용자 입력, 문자열 조작, UI 간 데이터 전달**
- 사용 환경: **Visual Studio + Windows Forms**

---

## 🗓 주차별 학습 내용 요약

| 주차 | 주요 학습 주제 | 추가된 기능 / 개념 | 예시 코드 및 설명 |
|------|----------------|--------------------|-------------------|
| **1주차** | Windows Forms 기본 구조 이해 | - `Form` 클래스 이해<br>- 버튼 클릭 이벤트(`Button.Click`) 처리<br>- `MessageBox.Show()` 사용 | ```csharp MessageBox.Show("안녕하세용~", "[공지사항]"); ```<br>→ 버튼 클릭 시 팝업창 출력 |
| **2주차** | 입력(TextBox)과 출력(Label/TextBox) 연결 | - `TextBox.Text` 프로퍼티 사용<br>- 이벤트 핸들러 간 데이터 전달<br>- `Dispose()`로 폼 종료 | ```csharp textBox1.Text = "안녕";```<br>→ 버튼 클릭 시 텍스트박스 내용 변경 |
| **3주차** | 사용자 입력 → 출력 변환 | - 입력된 문자열을 가공해서 다른 컨트롤에 출력<br>- 문자열 결합(`+`)과 개행(`\r\n`) 사용 | ```csharp textBox2.Text = textBox1.Text + "님 코로나 19 조심~";``` |
| **4주차** | MessageBox 심화 사용 | - 메시지 박스의 제목/내용 제어<br>- `Convert.ToChar()`로 특수문자 출력 처리 | ```csharp MessageBox.Show(textBox1.Text + "님 오후수업 화이팅", Convert.ToChar(34) + "\"[안내사항]\"" + Convert.ToChar(34)); ``` |
| **5주차** | 복합 데이터 처리 및 문자열 포맷 | - 여러 입력(TextBox1, TextBox2) 결합<br>- 줄바꿈(`\n`, `\r\n`) 활용<br>- 메시지박스와 텍스트박스 동시 출력 | ```csharp textBox3.Text = textBox1.Text + "님~~~!,\r\n당신의 학번은" + textBox2.Text + "\r\n입니다."; ``` |

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
