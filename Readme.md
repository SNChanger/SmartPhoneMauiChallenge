#このプロジェクトについて

Spajamでみんながスマホアプリを進めていたからやってみたよ。

## 技術構成

### 開発環境

VisualStudio2022対応

### 各ページの作成

.Net MAUIのテンプレートファイルを使って作成

### 資料作成時の参考資料

https://github.blog/2022-02-14-include-diagrams-markdown-files-mermaid/

### メニュー画面の最終的な遷移(ReleasePlan LastFlow)
```mermaid
flowchart LR
    subgraph App
        subgraph Menu
           userMemoTab -->userMemoDetail
           itemListTab -->itemList
           facilitySearchTab -->facilitySearchDisplay
           medicinedinputFormTab --> medicinedinputForm
        end
    end
User --> App --> Display
```
#### 各画面の実装予定内容
##### 過去の受診内容一覧
##### 画面側概要
入力画面で保存した内容の受診履歴一覧を表示する
受診履歴をクリックすることで詳細画面へ遷移する
##### データ遷移
```mermaid
sequenceDiagram
    participant イベント元プログラム
    participant お薬一覧取得
    participant 保存先
    イベント元プログラム->>お薬一覧取得: 指定したアカウントの受診結果一覧取得を呼び出し
    お薬一覧取得->>保存先: 指定したアカウントの受診結果一覧取得命令を実行
    保存先->>お薬一覧取得: 指定したアカウントの受診結果一覧取得命令の実行結果を返却
    お薬一覧取得->>イベント元プログラム: 指定したアカウントの受診結果一覧取得結果を返却
    loop １ページに表示するデータ分
    イベント元プログラム->>イベント元プログラム: 取得した一覧について、XAML側に反映する
    end
```


