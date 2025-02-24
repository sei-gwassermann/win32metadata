﻿using System;
using System.Runtime.InteropServices;
using Windows.Win32.Interop;

namespace Windows.Win32.Storage.FileSystem
{
    [Flags]
    public enum FIND_FIRST_EX_FLAGS : uint
    {
        FIND_FIRST_EX_CASE_SENSITIVE = 0x00000001,
        FIND_FIRST_EX_LARGE_FETCH = 0x00000002,
        FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY = 0x00000004
    }

    [Flags]
    public enum DEFINE_DOS_DEVICE_FLAGS : uint
    {
        DDD_RAW_TARGET_PATH = 0x00000001,
        DDD_REMOVE_DEFINITION = 0x00000002,
        DDD_EXACT_MATCH_ON_REMOVE = 0x00000004,
        DDD_NO_BROADCAST_SYSTEM = 0x00000008,
        DDD_LUID_BROADCAST_DRIVE = 0x00000010,
    }

    [Flags]
    public enum FILE_FLAGS_AND_ATTRIBUTES : uint
    {
        FILE_ATTRIBUTE_READONLY = 0x00000001,
        FILE_ATTRIBUTE_HIDDEN = 0x00000002,
        FILE_ATTRIBUTE_SYSTEM = 0x00000004,
        FILE_ATTRIBUTE_DIRECTORY = 0x00000010,
        FILE_ATTRIBUTE_ARCHIVE = 0x00000020,
        FILE_ATTRIBUTE_DEVICE = 0x00000040,
        FILE_ATTRIBUTE_NORMAL = 0x00000080,
        FILE_ATTRIBUTE_TEMPORARY = 0x00000100,
        FILE_ATTRIBUTE_SPARSE_FILE = 0x00000200,
        FILE_ATTRIBUTE_REPARSE_POINT = 0x00000400,
        FILE_ATTRIBUTE_COMPRESSED = 0x00000800,
        FILE_ATTRIBUTE_OFFLINE = 0x00001000,
        FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 0x00002000,
        FILE_ATTRIBUTE_ENCRYPTED = 0x00004000,
        FILE_ATTRIBUTE_INTEGRITY_STREAM = 0x00008000,
        FILE_ATTRIBUTE_VIRTUAL = 0x00010000,
        FILE_ATTRIBUTE_NO_SCRUB_DATA = 0x00020000,
        FILE_ATTRIBUTE_EA = 0x00040000,
        FILE_ATTRIBUTE_PINNED = 0x00080000,
        FILE_ATTRIBUTE_UNPINNED = 0x00100000,
        FILE_ATTRIBUTE_RECALL_ON_OPEN = 0x00040000,
        FILE_ATTRIBUTE_RECALL_ON_DATA_ACCESS = 0x00400000,

        FILE_FLAG_WRITE_THROUGH = 0x80000000,
        FILE_FLAG_OVERLAPPED = 0x40000000,
        FILE_FLAG_NO_BUFFERING = 0x20000000,
        FILE_FLAG_RANDOM_ACCESS = 0x10000000,
        FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000,
        FILE_FLAG_DELETE_ON_CLOSE = 0x04000000,
        FILE_FLAG_BACKUP_SEMANTICS = 0x02000000,
        FILE_FLAG_POSIX_SEMANTICS = 0x01000000,
        FILE_FLAG_SESSION_AWARE = 0x00800000,
        FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000,
        FILE_FLAG_OPEN_NO_RECALL = 0x00100000,
        FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000,

        PIPE_ACCESS_DUPLEX = 0x00000003,
        PIPE_ACCESS_INBOUND = 0x00000001,
        PIPE_ACCESS_OUTBOUND = 0x00000002,

        SECURITY_ANONYMOUS = (Windows.Win32.Security.SECURITY_IMPERSONATION_LEVEL.SecurityAnonymous << 16),
        SECURITY_IDENTIFICATION = (Windows.Win32.Security.SECURITY_IMPERSONATION_LEVEL.SecurityIdentification << 16),
        SECURITY_IMPERSONATION = (Windows.Win32.Security.SECURITY_IMPERSONATION_LEVEL.SecurityImpersonation << 16),
        SECURITY_DELEGATION = (Windows.Win32.Security.SECURITY_IMPERSONATION_LEVEL.SecurityDelegation << 16),
        SECURITY_CONTEXT_TRACKING = 0x00040000,
        SECURITY_EFFECTIVE_ONLY = 0x00080000,
        SECURITY_SQOS_PRESENT = 0x00100000,
        SECURITY_VALID_SQOS_FLAGS = 0x001F0000
    }

    [Flags]
    public enum FILE_ACCESS_RIGHTS : uint
    {
        FILE_READ_DATA = 0x0001,
        FILE_LIST_DIRECTORY = 0x0001,

        FILE_WRITE_DATA = 0x0002,
        FILE_ADD_FILE = 0x0002,

        FILE_APPEND_DATA = 0x0004,
        FILE_ADD_SUBDIRECTORY = 0x0004,
        FILE_CREATE_PIPE_INSTANCE = 0x0004,

        FILE_READ_EA = 0x0008,

        FILE_WRITE_EA = 0x0010,

        FILE_EXECUTE = 0x0020,
        FILE_TRAVERSE = 0x0020,

        FILE_DELETE_CHILD = 0x0040,

        FILE_READ_ATTRIBUTES = 0x0080,

        FILE_WRITE_ATTRIBUTES = 0x0100,

        DELETE = 0x00010000,
        
        READ_CONTROL = 0x00020000,

        WRITE_DAC = 0x00040000,

        WRITE_OWNER = 0x00080000,
        
        SYNCHRONIZE = 0x00100000,

        STANDARD_RIGHTS_REQUIRED = 0x000F0000,

        STANDARD_RIGHTS_READ = READ_CONTROL,
        STANDARD_RIGHTS_WRITE = READ_CONTROL,
        STANDARD_RIGHTS_EXECUTE = READ_CONTROL,

        STANDARD_RIGHTS_ALL = 0x001F0000,

        SPECIFIC_RIGHTS_ALL = 0x0000FFFF,

        FILE_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x1FF),

        FILE_GENERIC_READ = (STANDARD_RIGHTS_READ | FILE_READ_DATA | FILE_READ_ATTRIBUTES | FILE_READ_EA | SYNCHRONIZE),

        FILE_GENERIC_WRITE = (STANDARD_RIGHTS_WRITE | FILE_WRITE_DATA | FILE_WRITE_ATTRIBUTES | FILE_WRITE_EA | FILE_APPEND_DATA | SYNCHRONIZE),

        FILE_GENERIC_EXECUTE = (STANDARD_RIGHTS_EXECUTE | FILE_READ_ATTRIBUTES | FILE_EXECUTE | SYNCHRONIZE)
    }

    public static unsafe partial class Apis
    {
        public const uint MAXIMUM_REPARSE_DATA_BUFFER_SIZE = 16 * 1024;
    }
}
