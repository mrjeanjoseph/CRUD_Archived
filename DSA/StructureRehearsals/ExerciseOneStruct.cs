namespace StructureRehearsals {
    struct ExerciseOneStruct {
        public int x;
        public int y;
    }

    struct ExerciseTwoStruct {
        public static int x = 28;
        public static int y = 52;
    }

    class ExerciseThreeStruct {
        //Employee is to be a structure members
        public struct employee {
            public string empName;
            public BirthDate Date;                
        }

        public struct BirthDate {
            public int Day;
            public int Month;
            public int Year;
        }
    }
}
