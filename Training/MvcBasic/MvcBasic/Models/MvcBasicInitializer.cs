﻿using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MvcBasic.Models
{
	public class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
	{
		protected override void Seed(MvcBasicContext context)
		{
			var members = new List<Member>
			{
				new Member
				{
					Name = "山田リオ",
					Email = "rio@wings.msn.to",
					Birth = new DateTime(1980, 6, 25),
					Married = false,
					Memo = "ピアノが大好きです"
				},
				new Member
				{
					Name = "日尾直弘",
					Email = "naohiro@wings.msn.to",
					Birth = new DateTime(1975, 7, 19),
					Married = false,
					Memo = "子供にも優しいお医者さんです。"
				},
				new Member
				{
					Name = "掛谷奈美",
					Email = "nami@wings.msn.to",
					Birth = new DateTime(1985, 8, 5),
					Married = false,
					Memo = "フラワーアレンジメントを勉強中です"
				},
				new Member
				{
					Name = "木村次郎",
					Email = "jiro@wings.msn.to",
					Birth = new DateTime(1970, 12, 15),
					Married = true,
					Memo = "山登りが趣味です。休日は、よく山へ出かけます。"
				},
				new Member
				{
					Name = "鈴木恵子",
					Email = "keiko@wings.msn.to",
					Birth = new DateTime(1984, 11, 23),
					Married = true,
					Memo = "子供と一緒にアニメを見るのが大好きです。"
				}
			};

			members.ForEach(m => context.Members.Add(m));
			context.SaveChanges();
		}
	}
}