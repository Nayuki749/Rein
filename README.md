# Rein
Discord Bot

![Rein](img/Rein.png)

## 概要

Discordのテキストチャンネルに投稿された文章を[棒読みちゃん](http://chi.usamimi.info/Program/Application/BouyomiChan/)で読み上げ、その音声をボイスチャンネルに流すbotプログラムです。

## 動作環境

* Windows 7 以降
* .NET Framework 4.6.1 およびそれに互換性のあるバージョン


## インストール方法、使い方

[github上のwiki](https://github.com/Nayuki749/Rein/wiki)を参照してください。


## 特徴

### 参加者全員に聞こえる読み上げbot

一般的な読み上げソフトは、音声をPCのスピーカーに流します。そのため、読み上げ音声はソフトを起動した人にだけ聞こえます。読み上げ音声を他の人に共有するには、ボイスチャンネルとは別の配信などを利用する必要があります。

Reinは、読み上げた音声をDiscordのボイスチャンネルに流します。そのため、 **ボイスチャンネルに参加している全員に同じ音声が聞こえます。** スマートフォンなどでDiscordを使っている参加者も読み上げ音声を聞くことができます。 

また、Reinはbotアカウントを介して読み上げ音声を流すため、読み上げが不要だと思ったら、botをミュートすれば対応できます。

### どんな用途に向いているか

Reinは以下のような状況に適しています：

* 読み上げ音声を参加者全員で聞きたいとき
* スマートフォンなど、読み上げソフトが実行できない環境の人にも読み上げ音声を共有したいとき

以下のような状況ならば、他の読み上げソフトの方が適しているかもしれません：

* 読み上げ音声が自分にだけ聞こえればいい場合
* 読み上げ音声を別の方法で配信する場合（動画配信など）

### 棒読みちゃんのコマンドを活用可能

棒読みちゃんを「配信者向け」に設定することで、棒読みちゃんの機能の一部をそのまま使用することができます。以下はその一例です。

* `教育(言葉=読み方)`コマンドを使用することで、読み方を登録することができます。
* `エコー)`コマンドを使用することで、読み上げ音声にエコーをかけることができます。

制限は以下の通りです：

* `Sound`：`Sound`コマンドの音声は使用者のPCでしか聞こえません。
（代わりに、ReinのSEプラグインを使用することで、ボイスチャンネル上で音声を再生することができます。）

### VOICEROIDの使用も可能

棒読みちゃんとVOICEROIDを連携させることで、VOICEROIDを使った読み上げも可能です。

### カスタマイズ可能なプラグイン

* 標準プラグインで「URLを省略するフィルタ」「発言の前に名前を付けくわえるフィルタ」などが実装されています。これらのプラグインは、設定ファイルを書き換えることで有効化／無効化が可能です。
* `SoundEffectPlugin`を使って、任意の音声ファイルをボイスチャンネルに流すことができます。
* `UserDefinedFilterPlugin`を使って、さらに細かなフィルタが設定できます。

### 仮想サウンドデバイスを使用

Reinではまず、棒読みちゃんの音声を「スピーカーのフリ」をした仮想サウンドデバイスに流すよう設定します。
そして、同じ仮想サウンドデバイスをBOTのマイク入力として、読み上げ音声をDiscordのボイスチャンネルに流します。

### 使い方
config.jsonファイルのtokenにBOTのトークンを設定
device_read，device_sound_effectに仮想オーディオデバイスを設定
bouyomichan_pathに棒読みちゃんの実行ファイルのパスを指定してください。
(\はエスケープシーケンスとなるためC:\\Programe Files\\のように\を\\にしてください。じゃないと例外が)
Rein.zipに入っているREADME.txtを見るとちゃんと表示されるかも!

config.jsonの編集が完了したらRein.exeを実行しBOTがログインされているかを確認してください。

*Voiceチャネルに参加させるには
BOTを呼びたいVoiceチャンネルに参加して
@bot名 comeで読み上げ開始
@bot名 byeで切断されます。

*読み上げたいテキストチャンネルを追加するには
追加したいテキストチャンネルで
@bot名 addchannelで追加されます

*読み上げ対象のテキストチャンネル削除
削除したいテキストチャネルで
@bot名 removechannelで読み上げ対象から除外します

*botが入室しているボイスチャンネルと読み上げているテキストチャンネルの確認
@bot名 where


## ライセンスおよび免責事項

[LICENSE](LICENSE)を参照してください。


## 権利表記

### ライブラリ、参考

* [BouyomiChanClient.cs - 棒読みちゃん](http://chi.usamimi.info/Program/Application/BouyomiChan/)
* [CommandLineParser](https://github.com/commandlineparser/commandline) ([MIT License](https://github.com/commandlineparser/commandline/blob/master/License.md))
* [Discord.Net](https://github.com/RogueException/Discord.Net) ([MIT License](https://github.com/RogueException/Discord.Net/blob/dev/LICENSE))
* [Jint](https://github.com/sebastienros/jint) ([BSD 2-Clause "Simplified" License](https://github.com/sebastienros/jint/blob/dev/LICENSE.txt))
* [libsodium](https://download.libsodium.org/doc/) ([ISC license](https://en.wikipedia.org/wiki/ISC_license))
* [NAudio](https://github.com/naudio/NAudio) ([Microsoft Public License (Ms-PL)](https://github.com/naudio/NAudio/blob/master/license.txt))
* [Newtonsoft Json.NET](https://www.newtonsoft.com/json) ([MIT License](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md))
* [NGettext](https://github.com/neris/NGettext) ([MIT License](https://github.com/neris/NGettext/blob/master/LICENSE))
* [opas.dll - Opus Interactive Audio Codec](http://opus-codec.org/) ([three-clause BSD license](http://opus-codec.org/license/))
* [Discord-Audio-Stream-Bot](https://github.com/BinkanSalaryman/Discord-Audio-Stream-Bot) （参考にさせていただいたコード）
