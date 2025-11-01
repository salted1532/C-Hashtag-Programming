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
