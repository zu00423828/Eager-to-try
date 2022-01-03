using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QandA : MonoBehaviour
{

    public Text q;
    public GameObject answer1, answer2;
    public List<QaA> Question = new List<QaA>();
    public static int index;
    public static string nonanswer;
    public static string answer;
    public int endindex;
    public int rand;
    public bool change;
    public static QandA qa;
	// Use this for initialization
	void Start ()
    {
        setquestion();
        if (choose.chooseindex != 0)
        {
            change = false;
            index = Question.FindIndex(x => x.ch + 1 == choose.chooseindex);
            endindex = index + 9;
        }
        else
        {
            change = true;
            random();
        }
        Instantiate(answer1);
        Instantiate(answer2);
        qa = this;
    }

    // Update is called once per frame
    void Update ()
    {
       
        if (GameObject.Find("Massage").GetComponent<Text>().text == "GAMEOVER")
        {
            CancelInvoke();
        }

        if (!GameObject.Find(answer1.name + "(Clone)"))
        {

            if (IsInvoking() == false)
                Invoke("inst", 0.7f);

        }

        if (!GameObject.Find(answer2.name + "(Clone)"))
        {

            if (IsInvoking() == false)
                Invoke("insd", 0.2f);

        }

        if (change == false)
        {
            if (index <= Question.Count)
            {
                if (index <= endindex)
                {
                    q.text = Question[index].question;
                    nonanswer = Question[index].notright_answer;
                    answer = Question[index].right_answer;
                }
                else
                {
                    q.text = "";
                    massage.mg.print();
                    if (GameObject.Find("Massage").GetComponent<Text>().text == "GREAT")
                    {
                        CancelInvoke();
                    }
                }

            }
        }
        else
        {
            q.text = Question[rand].question;
            nonanswer = Question[rand].notright_answer;
            answer = Question[rand].right_answer;

        }
        

    }

    void setquestion()
    {
        //第0章
        Question.Add(new QaA { ch = 0, question = "組合語言是否為低階語言？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 0, question = "程式容易維護不是高階語言的優點？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 0, question = "直譯器(interpreter)翻譯後是否會產生目的檔？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 0, question = "繼承性(Inheritance)、封裝性(Encapsulation)及多型性(Polymorphism)屬於物件導向程式特性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 0, question = "機器語言是能直接讓電腦接受的程式語言？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 0, question = "機器語言是執行速度最快的語言？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 0, question = "美國國防部基於軍事需要設計的標準語言是LOGO？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 0, question = "JAVA適合應用在人工智慧的軟體開發？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 0, question = "FORTRAN適合科學及工程方面的計算？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 0, question = "關編譯器(Compiler)翻譯後會產生目的檔？", notright_answer = "No", right_answer = "Yes" });

        //第1章
        Question.Add(new QaA { ch = 1, question = "C# 專案檔副檔名為cs？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 1, question = "C# 是以方案來管理大型應用程式？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 1, question = "「按鈕」工具是一種物件？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 1, question = "「Button1」控制項是事件？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 1, question = "描述「Label1」與「Label2」兩個不一樣的物件是屬性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 1, question = "設定Form標題欄文字，需更改Title屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 1, question = "C# 不支援JavaScript？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 1, question = "Assembly不支援C#？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 1, question = "在Visual Studio 2015環境中，MSDN專業版(Professional)是提供給小型團隊軟體開發？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 1, question = ".NET Framework 不支援Visual Basic？", notright_answer = "Yes", right_answer = "No" });

        //第2章
        Question.Add(new QaA { ch = 2, question = "控制項Text屬性功能為設定控制項標題？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 2, question = "資料型態 double 在記憶體中所佔據的空間不是8 bytes？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 2, question = "資料型態 long 最適合用來儲存「身分證字號」？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 2, question = "資料型態 int 最適合用來儲存「98000」？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 2, question = "case 是不是C# 的關鍵字？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 2, question = "資料型態 char 最適合用來儲存「姓名」？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 2, question = "資料型態 DateTime 最適合用來儲存「生日」？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 2, question = "資料型態 float 最適合用來儲存「員工薪水」？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 2, question = "假設有一資料常值為true，儲存此資料的資料型態是否為 bool？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 2, question = "int score=55 ，要將score變數顯示在lblScore標籤上，其程式為 lblScore.Text=score.ToString()？", notright_answer = "No", right_answer = "Yes" });

        //第3章
        Question.Add(new QaA { ch = 3, question = "Windows Form應用程式會使用Form控制項來當容器？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 3, question = "在Form設計階段要修改控制項屬性設定，要開啟屬性視窗？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 3, question = "想要改變一個物件的性質，就要改變物件的常數？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 3, question = "屬性Name是所有物件都有？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 3, question = "要改變Form標題欄的圖示，須設定ControlBox屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 3, question = "在Form設計階段，快按兩下Form空白處，會進入DoubleClick事件處理函式？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 3, question = "在Form上快按兩下，不會觸動Load事件？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 3, question = "Button控制項無法點按，須設定Visible屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 3, question = "Form載入時會觸發Load事件？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 3, question = "例外處理中發生錯誤時要處理的程式碼，要寫在else區塊中？", notright_answer = "Yes", right_answer = "No" });

        //第4章
        Question.Add(new QaA { ch = 4, question = "switch不是選擇結構？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 4, question = "執行if (i>0) { x=\"OK\"} else { x=\"NO\" }時不會造成錯誤？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 4, question = "a在大於等於60，小於等於100之間的條件式寫法為 60 <=a<=100？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 4, question = "得知選項按鈕是否被選取，要檢查Checked屬性值？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 4, question = "1 To 10不能作為switch敘述的條件值？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 4, question = "同群組的選項按鈕維持只有一個被選取是靠Checked屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 4, question = "GroupBox控制項左上角標題是由Text屬性來設定？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 4, question = "RadionButton與CheckBox群組兩者都可以可以做多選？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 4, question = "RadionButton控制項可以包含其他控制項？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 4, question = "若RadionButton有多組選項要隔離，可使用GroupBox控制項來達成？", notright_answer = "No", right_answer = "Yes" });

        //第5章
        Question.Add(new QaA { ch = 5, question = "for 是C# 的重複結構指令？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 5, question = "Timer控制項物件每1秒執行1次Tick事件，Interval屬性值設定100？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 5, question = "若 C# 迴圈內數值變數會有規則遞減或遞增時，最為適合使用while…重複結構？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 5, question = "當迴圈內的敘述執行次數無法預知時應該使用while…迴圈?", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 5, question = "for(int k=-5 k<=6 k++){x += \" * \" }，請問執行後x字串的*是否有5個？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 5, question = "迴圈內敘述區段可能不會執行應該使用while…迴圈？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 5, question = "do…while敘述可搭配end指令，來跳離迴圈？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 5, question = "PictureBox控制項中圖片大小等比例自動調整，須設定SizeMode屬性值為Zoom？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 5, question = "Timer控制項隱含有重複結構功能？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 5, question = "如果要取得目前日期與時間可使用DateTime.Date控制項？", notright_answer = "Yes", right_answer = "No" });

        //第6章
        Question.Add(new QaA { ch = 6, question = "int[] A = new int[6] ，陣列A共有4個陣列元素？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 6, question = "陣列元素括號內的數字稱為註標或索引？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 6, question = "陣列是指將同性質資料集中放在連續記憶體位址？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 6, question = "使用SetSelected方法或屬性可取得清單控制項的項目個數？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 6, question = "使用Clear方法可以清除陣列指定元素內容？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 6, question = "ListBox清單控制項可以讓使用者輸入文字資料？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 6, question = "ListBox控制項中項目可以複選，須設定SelectionMode屬性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 6, question = "ListBox控制項要插入新的項目到指定位置時，可使用Insert方法？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 6, question = "要取得ListBox控制項存放資料的總數，可從Items.Total屬性取得？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 6, question = "清除ListBox控制項中的所有資料項目，須使用Items.Clear方法？", notright_answer = "No", right_answer = "Yes" });

        //第7章
        Question.Add(new QaA { ch = 7, question = "LinkLabel控制項按下但未放開時，超連結文字顯示的顏色須設定VisitedLinkColor屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 7, question = "ToolTip控制項顯示提示時間，須設定AutoPopDelay屬性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 7, question = "TrackBar控制項目前滑動鈕數值，設定或取得要使用Minimum屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 7, question = "ScrollBar控制項使用者能輸入的最大數值，設定或取得要使用Maximum屬性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 7, question = "MonthCalender控制項使用者選取開始日期，要使用SelectionEnd屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 7, question = "DateTimePicker控制項顯示MonthCalender，要使用ShowUpDown屬性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 7, question = "linkLabel1.Text = \"tw.yahoo.com\" linkLabel1.LinkArea = new LinkArea(8，3)，tw.yaho有超連結功能？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 7, question = "改變捲軸控制項Value屬性值時，會觸動ValueChanged事件？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 7, question = "NumericUpDown數字鈕控制項顯示小數位數，須設定Minimum屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 7, question = "MonthCalendar控制項選取日期同時處理，程式碼要寫在DateChanged事件中？", notright_answer = "No", right_answer = "Yes" });

        //第8章
        Question.Add(new QaA { ch = 8, question = "事件處理函式是屬於C# 的方法？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 8, question = "自訂方法傳遞引數最多可以有4個？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 8, question = "參考呼叫 (Call By Reference)是一種副本概念？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 8, question = "C# 自訂方法參數傳遞不可採用傳值方式？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 8, question = "自訂方法內虛引數不可以是變數Data Type？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 8, question = "離開方法可使用return敘述？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 8, question = "宣告的變數是區域變數不屬於方法的特色？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 8, question = "呼叫程式實引數與被呼叫程式虛引數兩者佔用相同記憶體位址？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 8, question = "引數傳遞方式預設為傳址呼叫？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 8, question = "參考呼叫 (Call By Reference)是一種正本的概念？", notright_answer = "No", right_answer = "Yes" });

        //第9章
        Question.Add(new QaA { ch = 9, question = "MouseMove滑鼠事件，可取得滑鼠游標所在位置？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 9, question = "滑鼠游標從外滑進去控制項，沒有停留立即再滑出來，則MouseMove事件並不會被觸動到？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 9, question = "滑鼠游標從外滑進去控制項，停留後再滑出來，則MouseMove滑鼠事件被觸動不只一次？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 9, question = "當使用者在Button控制項上按一下立即放開，則DoubleClick滑鼠事件並不會被觸動到？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 9, question = "Click滑鼠事件，可用e.Button 來偵測哪個滑鼠鍵被按下？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 9, question = "檢查使用者所輸入的字元是否合乎條件，程式碼通常要寫在KeyPress事件？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 9, question = "Windows Form可以完全支援C# 觸控手勢？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 9, question = "支援觸控手勢伸展或捏合(Zoom)動作，程式碼要寫在MouseClick滑鼠事件？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 9, question = "如果要確定使用者是否為長按觸控，要檢查MouseClick事件的e.Button值？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 9, question = "在KeyDown事件中可使用e.KeyValue屬性值取得輸入按鍵的ASCII值？", notright_answer = "No", right_answer = "Yes" });

        //第10章
        Question.Add(new QaA { ch = 10, question = "控制項要與快顯功能表建立關聯必須使用ContextMenuStrip屬性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 10, question = "工具列必須使用ToolBar控制項來建立？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 10, question = "ToolStrip 控制項同時顯示文字和圖示，須將DisplayStyle屬性值設定為None？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 10, question = "功能表項目是MenuItem物件？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 10, question = "功能表項目中插入Separator可以加入一個分隔線，可在功能表按下右鍵，並執行快顯功能表？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 10, question = "ToolStrip 控制項的項目只要顯示文字，DisplayStyle屬性設定為None？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 10, question = "功能表項目menuItem1要變成核取記號，寫法為menuItem1.Checked = true？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 10, question = "功能表項目menuItem1要設為失效不啟用，敘述寫法為menuItem1.Enabled = false？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 10, question = "設定功能表項目快速鍵，須設定ToolTipText屬性？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 10, question = "設定功能表項目的小圖示，須設定Images屬性？", notright_answer = "Yes", right_answer = "No" });

        //第11章 
        Question.Add(new QaA { ch = 11, question = "欲開啟對話方塊，必須呼叫該對話方塊的OpenDialog方法？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 11, question = "FontDialog 的ShowHelpg屬性不是決定是否要顯示？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 11, question = "RichTextBox控制項載入文字檔資料，須使用Load方法？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 11, question = "RichTextBox控制項寫入資料到文字檔，須使用SaveFile方法？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 11, question = "欲使RichTextBox控制項內的資料能連結URL，須將DetectUrls屬性設為true？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 11, question = "連結到指定URL須使用GetURL方法？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 11, question = "RichTextBox控制項指定撰取文字的背景顏色，必須設定SelectionBackColor屬性？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 11, question = "RichTextBox控制項將撰取的範圍複製到剪貼簿，必須使用Cut方法？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 11, question = "使用檔案類別來讀寫資料檔，則必須在程式最開頭撰寫using System.IO？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 11, question = "資料寫入至指定的資料檔，可使用StreamReader類別物件？", notright_answer = "Yes", right_answer = "No" });

        //第12章
        Question.Add(new QaA { ch = 12, question = "設定顏色透明度、紅色、綠色、藍色等四種不同屬性值，可以用RGB方法調配出各種顏色效果？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 12, question = "String物件無法設定顏色？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 12, question = "有一Button物件btn，取得該物件紅色值，可使用的方式為btn.BackColor.R？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 12, question = "Graphics物件顯示文字須使用DragTextShow方法？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 12, question = "Graphics物件線製線段須使用DrawLine方法？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 12, question = "有一PictureBox控制項，其物件名稱為pic，程式執行時載入C:\apple.jpg，應使用pic.Load(\"c:\\apple.jpg\")？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 12, question = "SaveImage方法可以將Bitmap圖形物件內的圖形儲存成圖像檔案？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 12, question = "Brushes物件可以填滿區塊內部顏色？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 12, question = "在Form內建立一個物件名稱為g的Graphics物件，應使用Graphics g = this.CreateGraphics()？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 12, question = "Clear方法可以把Graphics物件從主記憶體中移除？", notright_answer = "Yes", right_answer = "No" });

        //第13章
        Question.Add(new QaA { ch = 13, question = "public可以把類別成員設為公開成員？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 13, question = "類別成員要設為私有成員須使用protected？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 13, question = "類別成員要設為保護成員須使用protected？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 13, question = "建構式與類別同名？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 13, question = "一個*.cs檔只可以定義最多3個類別？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 13, question = "定義屬性為C# 的存取子的功能？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 13, question = "定義靜態成員可使用static保留字？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 13, question = "C# 會依照輸入引數不同而區別所呼叫方法，稱之為多載方法？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 13, question = "方法宣告為private，表示該方法是公開型態？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 13, question = "Form類別是繼承自System.Page.Form類別？", notright_answer = "Yes", right_answer = "No" });

        //第14章
        Question.Add(new QaA { ch = 14, question = "Access當資料庫則必須在程式最開頭撰寫using System.Data？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 14, question = "SQL Server當資料庫則必須在程式最開頭撰寫using System？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 14, question = "Command物件可以執行SQL語法？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 14, question = "ADO.NET目前最新版為2.0？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 14, question = "Connection物件可以開啟和關閉連接資料庫？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 14, question = "使用SQL語法INSERT可查詢資料表記錄？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 14, question = "使用SQL語法INSERT陳述式可新增資料表記錄？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 14, question = "刪除資料表記錄可使用SQL語法DELETE陳述式？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 14, question = "建立二維資料控制項，顯示和編修各種不同資料來源的表格式資料，可使用DataSet控制項？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 14, question = "使用DataAdapter物件Update方法可以將資料表資料一次填入記憶體的DataSet？", notright_answer = "Yes", right_answer = "No" });

        //第15章
        Question.Add(new QaA { ch = 15, question = "ASP.NET網頁程式在網路上供使用者瀏覽，伺服器網站須架設IBM軟體？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 15, question = "在ASP.NET專案中，存放資料庫檔案的資料夾名稱為App_Data？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 15, question = "SqlDataSource控制項用String屬性來設定資料庫連接字串？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 15, question = "ASP.NET的網頁程式文件中，不包含HTML標記語法？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 15, question = "DetailsView資料繫結控制項，一頁只能顯示一筆記錄資料？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 15, question = "GridView資料繫結控制項，沒有分頁功能？", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 15, question = "DetailsView資料繫結控制項，沒有排序功能？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 15, question = "GridView資料繫結控制項，預設一頁可顯示10筆記錄？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 15, question = "jQuery Mobile無法搭配ASP.NET整合設計？", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 15, question = "jQuery Mobile用data-role=\"footer\" 敘述來指定網頁的頁首？", notright_answer = "Yes", right_answer = "No" });

        //
        Question.Add(new QaA { ch = 16, question = "我們現在所在的地方是M棟B2", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 16, question = "PLA材質的3D列印線材是有毒的", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 16, question = "2的10次方為1026", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 16, question = "Unity為遊戲開發引擎", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 16, question = "弘光資管系的簡稱為「CSIM」", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 16, question = "奧運是4年舉辦一次", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 16, question = "今年為2020年", notright_answer = "Yes", right_answer = "No" });
        Question.Add(new QaA { ch = 16, question = "水的密度為1", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 16, question = "南投是台灣唯一一個不靠海的縣市", notright_answer = "No", right_answer = "Yes" });
        Question.Add(new QaA { ch = 16, question = "CPR的步驟為濕、搓、沖、捧、擦", notright_answer = "Yes", right_answer = "No" });
    }
    void inst()
    {
        Instantiate(answer1);
    }
    void insd()
    {
        Instantiate(answer2);
    }
    public void random()
    {
         Random.seed = System.Guid.NewGuid().GetHashCode();
         rand = Random.Range(0,159);
         print(rand);
    }
}

public class QaA
{
    public int ch;
    public string question;
    public string notright_answer;
    public string right_answer;
}