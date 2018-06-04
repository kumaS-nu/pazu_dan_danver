RecordShow.cs
ランキング閲覧用のスクリプト。
空のオブジェクトにくっつける。
no1～no5 はUI Textをアタッチするところ。

StagetimeGetter.cs
クリアタイム取得・表示スクリプト。
空のオブジェクトにくっつける。
filename 参照するファイルネーム（"Stage1.dat""Stage2.dat"）
text UI Textをアタッチ

Totaltime.cs
合計タイムを表示。
空のオブジェクトにくっつける。
stage1 Stage1のタイムのStagetimeGetter.csをくっつけたオブジェクトをアタッチ。
stage2 Stage2のタイムのStagetimeGetter.csをくっつけたオブジェクトをアタッチ。
text UI Textをアタッチ。

RecordSave.cs
ランキングセーブ用のスクリプト。
名前入力のところコメントアウト中。
空のオブジェクトにくっつける。
stage1 Stage1のタイムのStagetimeGetter.csをくっつけたオブジェクトをアタッチ。
stage2 Stage2のタイムのStagetimeGetter.csをくっつけたオブジェクトをアタッチ。
totaltime Totaltime.csをくっつけたオブジェクトをアタッチ。