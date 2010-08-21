#region Auto-generated classes for school database on 2009-06-21 11:05:07Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from school on 2009-06-21 11:05:07Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using DbLinq.Data.Linq;
using DbLinq.Data.Linq.Mapping;

namespace school
{
	public partial class School : DbLinq.Data.Linq.DataContext
	{
		public School(System.Data.IDbConnection connection)
		: base(connection, new DbLinq.MySql.MySqlVendor())
		{
		}

		public School(System.Data.IDbConnection connection, DbLinq.Vendor.IVendor vendor)
		: base(connection, vendor)
		{
		}

		public Table<Student> Students { get { return GetTable<Student>(); } }

	}

	[Table(Name = "school.students")]
	public partial class Student : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int Age

		private int _age;
		[DebuggerNonUserCode]
		[Column(Storage = "_age", Name = "age", DbType = "int", CanBeNull = false)]
		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value != _age)
				{
					_age = value;
					OnPropertyChanged("Age");
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged("ID");
				}
			}
		}

		#endregion

		#region string Name

		private string _name;
		[DebuggerNonUserCode]
		[Column(Storage = "_name", Name = "name", DbType = "varchar(255)", CanBeNull = false)]
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value != _name)
				{
					_name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		#endregion

		#region int RollNo

		private int _rollNo;
		[DebuggerNonUserCode]
		[Column(Storage = "_rollNo", Name = "rollno", DbType = "int", CanBeNull = false)]
		public int RollNo
		{
			get
			{
				return _rollNo;
			}
			set
			{
				if (value != _rollNo)
				{
					_rollNo = value;
					OnPropertyChanged("RollNo");
				}
			}
		}

		#endregion

	}
}
