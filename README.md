# ☕ SmartCoffeeSystem — 智慧咖啡廳 POS 點餐與後台營運管理系統

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?logo=csharp)](https://learn.microsoft.com/dotnet/csharp/)
[![ORM](https://img.shields.io/badge/ORM-Entity%20Framework%206-0078D4)](https://learn.microsoft.com/ef/ef6/)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-CC2927?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)
[![UI](https://img.shields.io/badge/UI-WinForms%20%7C%20SunnyUI%20%7C%20FontAwesome-EA580C)](https://github.com/yhuse/SunnyUI)

**SmartCoffeeSystem** 是一套專為現代咖啡廳與餐飲門市打造的整合式 **前台 POS 點餐收銀** 與 **後台營運管理系統**（含 **KDS 後廚即時出餐看板**）。  
系統採用 **C# (.NET Framework 4.8) Windows Forms** 與 **Entity Framework 6** 開發，具備完整的 **RBAC 12 大角色權限控管**、**BCrypt 密碼雜湊與防暴力破解機制**、**資料庫 Transaction 交易一致性保障**，以及**多維度視覺化營運數據分析**。

> 📄 **架構與命名規範文件**：關於本專案的詳細三層式架構、資料庫 ER 設計與命名規則，請參閱 👉 [**ARCHITECTURE.md**](./ARCHITECTURE.md)

---

## 🚀 給面試官的快速啟動指南 (Quick Start & Database Setup)

為了讓您下載專案後能直接編譯並體驗完整資料與圖表，專案內已附贈完整的 **`CoffeeShop` 資料庫檔案**（位於 [`Database/`](./Database) 資料夾中），提供以下兩種匯入方式（**二選一即可**）：

### 步驟 1：建立與還原資料庫 (`CoffeeShop`)

#### 方式 A：執行 SQL 初始化腳本（⭐ 最推薦，不受 SQL Server 版本限制）
1. 開啟 **SQL Server Management Studio (SSMS)** 並連線至本機 SQL Server（`.` 或 `localhost`）。
2. 點擊左上角「**檔案**」➔「**開啟**」➔ 選擇專案目錄下的 [`Database/CoffeeShop_Init.sql`](./Database/CoffeeShop_Init.sql)。
3. 按下 **`F5` (執行)**，即可在 1 秒內自動建立 `CoffeeShop` 資料庫、13 張資料表結構與所有測試資料（商品、分類、客製化選項、會員、訂單、員工與權限）。

#### 方式 B：還原 `.bak` 備份檔
1. 若您的環境為 SQL Server 2025 (v17) 以上，可將 [`Database/CoffeeShop.bak`](./Database/CoffeeShop.bak) 複製至公開目錄（如 `C:\Users\Public\CoffeeShop.bak`）。
2. 於 SSMS 的「**資料庫**」節點按右鍵 ➔「**還原資料庫**」➔ 選擇「**裝置**」並指向 `CoffeeShop.bak` 即可完成還原。

---

### 步驟 2：檢查連線設定與啟動專案

1. 本專案 [`SmartCoffeeSystem/App.config`](./SmartCoffeeSystem/App.config) 預設使用本機 **Windows 整合驗證 (`Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True;`)**。
   - 若您的 SQL Server 執行個體名稱為 `.\SQLEXPRESS` 或 `(localdb)\MSSQLLocalDB`，僅需將 `App.config` 中的 `data source=.` 修改為對應名稱即可。
2. 使用 **Visual Studio 2022 / 2026** 開啟根目錄下的 [`SmartCoffeeSystem.sln`](./SmartCoffeeSystem.sln)（或 [`SmartCoffeeSystem.slnx`](./SmartCoffeeSystem.slnx)）。
3. 還原 NuGet 套件並按下 **`F5`** 啟動系統。

---

### 步驟 3：預設測試登入帳號

登入畫面具備動態繪製之 4 碼圖形驗證碼，請輸入以下測試帳號與畫面上的驗證碼登入：

| 角色身份 | 登入帳號 (`Username`) | 登入密碼 (`Password`) | 權限範圍說明 |
| :--- | :---: | :---: | :--- |
| **總經理 (最高權限管理員)** | **`master`** | **`123456789`** | ⭐ **推薦使用**：擁有全部 **12 項系統權限**（可進入前台 POS 點餐與後台所有管理模組） |
| **業務經理** | `Liugihao` | `123456789` | 擁有 8 項權限（前台 POS、儀表板、商品、會員、營收、員工管理，無系統備份與日誌權限，可用於測試 RBAC 選單動態隱藏） |

---

## ✨ 核心功能與技術亮點 (Key Features & Technical Highlights)

### 1. 🔐 企業級資安防護與 RBAC 雙重權限控管
- **BCrypt 不可逆雜湊加密**：所有員工密碼皆透過 `BCrypt.Net-Next` 進行加鹽雜湊 (`PasswordHash`) 儲存，杜絕明文密碼外洩風險。
- **GDI+ 動態圖形驗證碼與防暴力破解**：登入畫面 (`FrmLogin`) 使用 GDI+ 即時繪製含干擾線與噪點之驗證碼，並結合 `LoginLog` 實作 **IP 頻率限制（10 分鐘內失敗達 10 次自動鎖定 10 分鐘）** 與 **自動清理 30 天前過期日誌**。
- **12 大權限雙重攔截 (RBAC)**：
  - 依職稱角色批次配置 12 項細粒度權限（`POS_System`、`Product_CRUD`、`Revenue_View`、`Database_Backup` 等）。
  - **第一層 UI 動態隱藏**：主選單 (`FrmMainMenu`) 與後台側邊欄 (`FrmAdmin`) 根據 `UserSession.Permissions` 自動隱藏無權限之按鈕與主分類。
  - **第二層開啟頁面攔截**：`OpenPageWithPermission()` 方法於切換子頁面時再次強制驗證權限，並同步更新互動式麵包屑導航 (Breadcrumb Navigation)。
- **人事與帳號狀態自動聯動**：於員工管理 (`UC_Employees`) 將員工改為「離職」或「停用」時，系統會自動將其 `Account.IsLocked` 設為 `true` 立即封鎖登入權限。

### 2. 🛒 高流暢度前台 POS 點餐與 ACID 交易結帳
- **記憶體快取與 `SuspendLayout` 防閃爍**：啟動 `FrmPOS` 時將上架商品與分類預先載入記憶體快取，切換分類與關鍵字即時搜尋完全不需重複查詢資料庫，搭配 `SuspendLayout()` / `ResumeLayout()` 實現零閃爍流暢體驗。
- **動態客製化規格系統**：透過 `ProductOptionGroups`、`ProductOptionItems` 與 `ProductOptionMapping` 多對多結構，點擊商品自動彈出 `FrmProductModal` 動態產生該商品專屬的冰塊、甜度、加料加價按鈕與防注入過濾備註欄 (`SanitizeRemark`)。
- **多元結帳與會員折抵 (`FrmCheckout`)**：
  - 支援手機號碼即時查詢會員等級折扣（如 9 折、85 折）與現有點數。
  - 支援 **點數折抵（1 點折 1 元，含最大可折抵上限防呆）**，並自動帶入會員預設載具（手機條碼 / 公司統編 / 紙本發票）與多元支付方式（現金、信用卡、LINE Pay、悠遊卡、點數全額付款）。
- **EF6 Database Transaction 交易保護**：結帳寫入「主訂單 (`Orders`)」、「訂單明細 (`OrderDetails`)」、「商品庫存扣除 (`Products.Stock`)」與「會員點數扣除與倍率回饋 (`Members.Point`)」全程包覆於 `db.Database.BeginTransaction()` 中，確保資料強一致性。

### 3. 👨‍🍳 KDS 後廚即時出餐看板 (`UC_OrderCardView` & `UC_OrderCard`)
- **5 秒智慧差異比對輪詢**：背景 `Timer` 每 5 秒檢查當日待製作訂單 (`OrderStatus == 1`)，透過 `SequenceEqual` 比對畫面現有訂單 ID 集合，**僅在有新單或狀態異動時才重繪卡片**，並自動記憶與還原捲軸位置 (`AutoScrollPosition`)。
- **逾時自動紅字警示與自適應高度**：每張 `UC_OrderCard` 根據訂單品項與客製化規格數量動態計算最佳卡片高度，且下單超過 15 分鐘未完成會自動將時間標示為粗體紅字提醒後廚優先製作。

### 4. 📊 營運儀表板、拖曳排序與報表分析 (`UC_Dashboard` & `UC_Revenue`)
- **即時 KPI 與同期趨勢比較**：首頁儀表板即時計算當月新增會員/商品、當日訂單數/營業額，並自動對比上月/昨日數據顯示紅綠漲跌百分比 (`↑` / `↓`)。
- **多維度視覺化圖表**：內建近 7 日營收平滑折線圖 (`Spline`)、分類營收佔比甜甜圈圖 (`Doughnut`)、近 7 日熱銷商品 TOP 5 橫向長條圖 (`Bar`)、訂單狀態分佈圖，以及自訂日期區間之會員/非會員營收貢獻比分析。
- **DataGridView 原生滑鼠拖曳排序 (Drag & Drop)**：儀表板支援直接以滑鼠左鍵拖曳商品或訂單列進行排序（含防誤觸緩衝區 `SystemInformation.DragSize` 與跨表格標籤隔離），放開滑鼠即自動更新資料庫 `Sort` 欄位。
- **後台 POS 預覽模式 (`IsPreviewMode`)**：商品管理頁面可一鍵啟動「POS 預覽模式」，讓管理員調整商品排序或上下架後直接檢視前台真實排版，同時自動鎖定結帳功能避免誤下單。

### 5. 💾 一鍵資料庫備份與單人模式強制還原 (`UC_BackupManager`)
- **完整備份 (`BACKUP DATABASE`)**：透過 GUI 選擇路徑即可將 `CoffeeShop` 匯出為 `.bak` 備份檔。
- **安全強制還原 (`RESTORE DATABASE`)**：還原時自動切換連線至 `master` 系統資料庫，依序執行 `SET SINGLE_USER WITH ROLLBACK IMMEDIATE`（強制中斷殘留連線避免被鎖死）➔ `RESTORE DATABASE ... WITH REPLACE` ➔ `SET MULTI_USER`，還原完成後自動重啟應用程式。

---

## 🛠️ 技術堆疊 (Tech Stack)

| 類別 | 採用技術 / 套件 | 版本 | 用途說明 |
| :--- | :--- | :---: | :--- |
| **開發框架** | .NET Framework (Windows Forms) | `v4.8` | 桌面應用程式核心框架 |
| **ORM 框架** | Entity Framework 6 (Database-First) | `6.5.2` | 資料庫物件關聯映射、LINQ 查詢與 Transaction 交易管理 |
| **資料庫** | Microsoft SQL Server (T-SQL) | `2019+` | 關聯式資料庫儲存、備份與還原 |
| **UI 元件庫** | SunnyUI | `3.9.8` | 現代化扁平風格控制項、對話框與自訂繁體中文語系覆寫 |
| **向量圖示庫** | FontAwesome.Sharp | `6.6.0` | 側邊導航欄與動態商品分類向量圖示渲染 |
| **資訊安全** | BCrypt.Net-Next | `4.2.0` | 員工帳號密碼不可逆加鹽雜湊與驗證 |
| **數據視覺化** | System.Windows.Forms.DataVisualization | `4.0` | MSChart 折線圖、甜甜圈圖與排行榜長條圖繪製 |

---

## 📂 專案結構概覽 (Project Structure)

```text
SmartCoffeeSystem/
├── Database/                        # 附贈之 SQL Server 資料庫腳本與備份檔
│   ├── CoffeeShop_Init.sql          # 完整建表與測試資料 SQL 腳本 (SSMS 按 F5 即可執行)
│   └── CoffeeShop.bak               # SQL Server .bak 備份檔
├── SmartCoffeeSystem/               # 主專案目錄
│   ├── View/                        # 14 個後台管理模組 UserControl (UC_*)
│   ├── models/                      # ViewModels、DTO 與 UserSession 權限狀態管理
│   ├── Services/                    # BCrypt 雜湊與資料存取服務
│   ├── ProductImages/               # 預設商品圖片資源
│   ├── FrmLogin.cs                  # 登入與安全驗證視窗
│   ├── FrmMainMenu.cs               # 前/後台權限分流主選單
│   ├── FrmPOS.cs                    # 前台 POS 點餐收銀系統
│   ├── FrmProductModal.cs           # 商品客製化規格與加價彈窗
│   ├── FrmCheckout.cs               # 會員折抵與多元支付結帳視窗
│   ├── FrmAdmin.cs                  # 後台管理系統主框架
│   └── POSModel.edmx                # Entity Framework 6 資料庫模型
├── ARCHITECTURE.md                  # 專案架構、資料庫 ER 圖與命名規則詳解
├── README.md                        # 專案總覽與快速啟動指南
└── SmartCoffeeSystem.sln            # Visual Studio 解決方案檔
```

---

## 🔗 相關連結 (Links)

- **GitHub Repository**: [https://github.com/sheng118137/SmartCoffeeSystem](https://github.com/sheng118137/SmartCoffeeSystem)
- **架構與命名規範文件**: [ARCHITECTURE.md](./ARCHITECTURE.md)
#   S m a r t C o f f e e S y s t e m  
 