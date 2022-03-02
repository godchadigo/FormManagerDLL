# FormManagerDLL

## 使用教學
- 1.加入參考(FormMangerdll.dll)
- 2.寫程式
- 3.Enjoy!
- 
``` C#
private FormManager fm1; //新增全局變量

public Form1()
{
  InitializeComponent();
  fm1 = new FormManager(flowLayoutPanel1,"Context1"); //實力化視窗管理器
}

/// <summary>
/// 創建畫面並顯示
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

private void Create(object sender, EventArgs e){
    fm1.AddPage("P1", new P1()); //新增畫面到視窗管理器
    fm1.SetPage("P1"); //顯示畫面
}

/// <summary>
/// 刪除畫面
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

private void Delete(object sender, EventArgs e){  
    //清空畫面(包括進行中的線程)
    fm1.RemovePage("P1") //從列表中刪除UserControl
    fm1.ResetPage("P1"); //從容器中刪除畫面
}

/// <summary>
/// 隱藏畫面
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

private void Hide(object sender, EventArgs e){  
    fm1.ClearPage() //隱藏所有畫面(畫面能在進行中)    
}

/// <summary>
/// 返回畫面
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

private void Back(object sender, EventArgs e){  
    fm1.BackPage() //返回畫面(畫面能在進行中)    
}
```
